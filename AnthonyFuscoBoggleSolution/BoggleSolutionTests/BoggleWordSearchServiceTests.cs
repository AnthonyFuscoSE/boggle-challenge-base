using System;
using System.Collections.Generic;
using System.Linq;
using AnthonyFuscoBoggleSolution;
using AnthonyFuscoBoggleSolution.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BoggleSolutionTests
{
    [TestClass]
    public class BoggleWordSearchTests
    {
        [TestMethod]
        public void Puzzle0Test()
        {
            //Arrange
            IDictionaryRepository dictionaryRepository = new DictionaryRepository();

            ITrieBuilder trieBuilder = new TrieBuilder(dictionaryRepository);

            BoggleWordSearchService boggleWordSearchService = new BoggleWordSearchService(trieBuilder);
            var board = "EEEOBASOOTALSANI";
            var expectedResults = Solution0Results();
            
            //Act
            HashSet<string> result = boggleWordSearchService.FindWordsInBoggle(board, 4, 4);

            //only care that tries look the same. 
            var resultString = Newtonsoft.Json.JsonConvert.SerializeObject(result.OrderBy(keys => keys));
            var expectedString = Newtonsoft.Json.JsonConvert.SerializeObject(expectedResults);

            //Assert
            Assert.AreEqual(expectedString, resultString);
        }

        [TestMethod]
        public void Puzzle1Test()
        {
            //Arrange
            IDictionaryRepository dictionaryRepository = new DictionaryRepository();

            ITrieBuilder trieBuilder = new TrieBuilder(dictionaryRepository);

            BoggleWordSearchService boggleWordSearchService = new BoggleWordSearchService(trieBuilder);
            var board = "WNNRILCDBGBEELNU";
            var expectedResults = Solution1Results();

            //Act
            HashSet<string> result = boggleWordSearchService.FindWordsInBoggle(board, 4, 4);

            //only care that tries look the same. 
            var resultString = Newtonsoft.Json.JsonConvert.SerializeObject(result.OrderBy(keys => keys));
            var expectedString = Newtonsoft.Json.JsonConvert.SerializeObject(expectedResults);

            //Assert
            Assert.AreEqual(expectedString, resultString);
        }

        [TestMethod]
        [DataRow("EEEOBASOOTALSANI", 4, 4, true)]
        [DataRow("EEEOBASOOTALSANII", 4, 4, false)]
        [DataRow("EEEOB@SOOTALSANII", 4, 4, false)]
        [DataRow("EEEOB@SOOTALSANI", 4, 4, false)]
        [DataRow("EEEOBaSOOTALSANI", 4, 4, true)]
        [DataRow("EEEOBASOOTALSANICCCC", 4, 5, true)]

        public void ValidatesBoard(string board, int numCol, int numRow, bool expected)
        {
            //Arrange
            Mock<ITrieBuilder> trieBuilderMock = new Mock<ITrieBuilder>();

            BoggleWordSearchService boggleWordSearchService = new BoggleWordSearchService(trieBuilderMock.Object);
            
            //Act
            bool result = boggleWordSearchService.IsValidBoggleBoard(board, numCol, numRow);
            
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void BoardArrayBuiltCorrectly()
        {
            //Arrange
            Mock<ITrieBuilder> trieBuilderMock = new Mock<ITrieBuilder>();
            string board = "EEEOBASOOTALSANI";
            int numCol = 4;
            int numRow = 4;

            BoggleWordSearchService boggleWordSearchService = new BoggleWordSearchService(trieBuilderMock.Object);
            char[,] expectedArray = new char[4,4];
            
            //Row 1 EEEO
            expectedArray[0, 0] = 'E';
            expectedArray[0, 1] = 'E';
            expectedArray[0, 2] = 'E';
            expectedArray[0, 3] = 'O';
            
            //Row 2 BASO
            expectedArray[1, 0] = 'B';
            expectedArray[1, 1] = 'A';
            expectedArray[1, 2] = 'S';
            expectedArray[1, 3] = 'O';

            //Row 3 OTAL
            expectedArray[2, 0] = 'O';
            expectedArray[2, 1] = 'T';
            expectedArray[2, 2] = 'A';
            expectedArray[2, 3] = 'L';
            
            //Row 4 SANI
            expectedArray[3, 0] = 'S';
            expectedArray[3, 1] = 'A';
            expectedArray[3, 2] = 'N';
            expectedArray[3, 3] = 'I';

            //Act
            var builtArray = boggleWordSearchService.CreateBoggleBoard(board, numCol, numRow);
            
            //only care that tries look the same. 
            var resultString = Newtonsoft.Json.JsonConvert.SerializeObject(builtArray);
            var expectedString = Newtonsoft.Json.JsonConvert.SerializeObject(expectedArray);

            //Assert
            Assert.AreEqual(expectedString, resultString);
        }

        private static HashSet<string> Solution0Results()
        {
            return new HashSet<string>
            {
                "AAL",
                "AALS",
                "AAS",
                "ABO",
                "ABOS",
                "AEOLIAN",
                "AIL",
                "AILS",
                "AIN",
                "ALOE",
                "ALOES",
                "ALS",
                "ALSO",
                "ANA",
                "ANAL",
                "ANAS",
                "ANATASE",
                "ANI",
                "ANIL",
                "ANILS",
                "ANLAS",
                "ANT",
                "ANTA",
                "ANTAE",
                "ANTAS",
                "ANTS",
                "ASANA",
                "ASANAS",
                "ASEA",
                "ASLANT",
                "BAA",
                "BAAL",
                "BAALS",
                "BAAS",
                "BAS",
                "BASAL",
                "BASE",
                "BAST",
                "BASTS",
                "BAT",
                "BATS",
                "BEAST",
                "BEASTS",
                "BEAT",
                "BEATS",
                "BEE",
                "BEES",
                "BEST",
                "BESTS",
                "BOA",
                "BOAS",
                "BOAST",
                "BOASTS",
                "BOAT",
                "BOATS",
                "BOS",
                "BOT",
                "BOTA",
                "BOTAS",
                "BOTS",
                "EASE",
                "EAST",
                "EASTS",
                "EAT",
                "EATS",
                "EOLIAN",
                "INTO",
                "LAIN",
                "LAS",
                "LASE",
                "LAST",
                "LASTS",
                "LAT",
                "LATS",
                "LIANA",
                "LIANAS",
                "LIN",
                "LINT",
                "LINTS",
                "LOAN",
                "LOO",
                "LOOS",
                "LOOSE",
                "LOSE",
                "LOST",
                "NAIL",
                "NAILS",
                "NAOS",
                "NATAL",
                "NIL",
                "NILS",
                "OAST",
                "OASTS",
                "OAT",
                "OATS",
                "OBE",
                "OBES",
                "OBESE",
                "OBTAIN",
                "OES",
                "OSE",
                "SAB",
                "SABE",
                "SABOT",
                "SABOTS",
                "SAE",
                "SAIL",
                "SAIN",
                "SAINT",
                "SAINTS",
                "SAL",
                "SALINA",
                "SALINAS",
                "SANTO",
                "SANTOS",
                "SAT",
                "SEA",
                "SEAT",
                "SEATS",
                "SEE",
                "SLAIN",
                "SLANT",
                "SLANTS",
                "SLAT",
                "SLATS",
                "SLOE",
                "SOB",
                "SOL",
                "SOLA",
                "SOLAN",
                "SOLI",
                "SOT",
                "SOTS",
                "STAB",
                "STAIN",
                "STOA",
                "STOAE",
                "STOAS",
                "STOB",
                "TAB",
                "TABES",
                "TAE",
                "TAIL",
                "TAILS",
                "TAIN",
                "TALI",
                "TAN",
                "TAO",
                "TAOS",
                "TAS"
            };
        }

        private static HashSet<string> Solution1Results()
        {
            return new HashSet<string>
            {
                "BED",
                "BEG",
                "BEGIN",
                "BEL",
                "BEN",
                "BIG",
                "BILGE",
                "BIN",
                "BLEB",
                "BLIN",
                "BUN",
                "BUNG",
                "BUNGLE",
                "DEB",
                "DEN",
                "ENG",
                "GEL",
                "GIB",
                "GIBE",
                "GIN",
                "GLIB",
                "GNU",
                "INN",
                "LEG",
                "LIB",
                "LIBEL",
                "LIN",
                "LINN",
                "NEB",
                "NIB",
                "NIL",
                "NUB",
                "UNBE",
                "WIG",
                "WIN",
                "WINCE",
                "WINCED"

            };
        }
    }
}
