﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Windows.Forms;

namespace ARKBreedingStats.ocr
{
    [DataContract]
    public class OCRTemplate
    {
        [DataMember]
        public string description = "";
        [DataMember]
        public string resolution = "";
        [DataMember]
        public int guiZoom = 100; // todo name / float? percentage? decimals?
        [DataMember]
        public List<int> fontSizes = new List<int>();
        [DataMember]
        public List<List<uint[]>> letterArrays = new List<List<uint[]>>();
        [DataMember]
        public List<List<char>> letters = new List<List<char>>();
        [DataMember]
        public List<Rectangle> labelRectangles = new List<Rectangle>();
        public Dictionary<string, int> labelNames = new Dictionary<string, int>();

        public List<List<int>> reducedIndices = new List<List<int>>(); // indices of letters for reduced set (only [0-9\.,/%:])

        public void init()
        {
            initLabelNames();
            initReducedIndices();
        }

        private void initLabelNames()
        {
            labelNames = new Dictionary<string, int>();
            labelNames.Add("Health", 0);
            labelNames.Add("Stamina", 1);
            labelNames.Add("Oxygen", 2);
            labelNames.Add("Food", 3);
            labelNames.Add("Weight", 4);
            labelNames.Add("MeleeDamage", 5);
            labelNames.Add("MovementSpeed", 6);
            labelNames.Add("Torpor", 7);
            labelNames.Add("Imprinting", 8);
            labelNames.Add("Level", 9);
            labelNames.Add("NameSpecies", 10);
            labelNames.Add("Tribe", 11);
            labelNames.Add("Owner", 12);
        }

        private void initReducedIndices()
        {
            reducedIndices = new List<List<int>>();
            string reducedChars = ":0123456789.,%/";
            for (int o = 0; o < fontSizes.Count; o++)
            {
                reducedIndices.Add(new List<int>());
                for (int c = 0; c < letters[o].Count; c++)
                {
                    if (reducedChars.IndexOf(letters[o][c]) != -1)
                        reducedIndices[o].Add(c);
                }
            }
        }

        public int fontSizeIndex(int fontSize, bool createIfNotExisting = false)
        {
            if (fontSizes.IndexOf(fontSize) == -1 && createIfNotExisting)
            {
                fontSizes.Add(fontSize);
                letterArrays.Add(new List<uint[]>());
                letters.Add(new List<char>());
                reducedIndices.Add(new List<int>());
            }
            return fontSizes.IndexOf(fontSize);
        }

        public OCRTemplate loadFile(string filename)
        {
            OCRTemplate ocrConfig = null;

            // check if file exists
            if (!File.Exists(filename))
            {
                MessageBox.Show("OCR-File '" + filename + "' not found. OCR is not possible without the config-file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(OCRTemplate));
            System.IO.FileStream file = System.IO.File.OpenRead(filename);

            try
            {
                ocrConfig = (OCRTemplate)ser.ReadObject(file);
                ocrConfig.init();
                Properties.Settings.Default.ocrFile = filename;
            }
            catch (Exception e)
            {
                MessageBox.Show("File Couldn't be opened or read.\nErrormessage:\n\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            file.Close();

            return ocrConfig;
        }

        public bool saveFile(string filename)
        {
            DataContractJsonSerializer writer = new DataContractJsonSerializer(typeof(OCRTemplate));
            try
            {
                System.IO.FileStream file = System.IO.File.Create(filename);
                writer.WriteObject(file, ArkOCR.OCR.ocrConfig);
                file.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during serialization.\nErrormessage:\n\n" + ex.Message, "Serialization-Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
