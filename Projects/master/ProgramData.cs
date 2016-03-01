/*
 * Created by Mad Nomad
 * User: Mad Nomad
 * Date: 27.02.2016
 * Time: 0:58
 */
using System;
using System.Collections.Generic;
using System.IO;

namespace Combats
{
    /// <summary>
    /// Description of ProgramData.
    /// </summary>
    public class ProgramData
    {
        public static string PlayerName;
        public static string RatingFilePath = (Directory.GetCurrentDirectory() + @"\data\records\top.csv");
        public static Dictionary<string, int> Rating;

    }
}
