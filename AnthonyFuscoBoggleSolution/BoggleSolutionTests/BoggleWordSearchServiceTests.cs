using System;
using System.Collections.Generic;
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
            Mock<IDictionaryRepository> dictionaryRepo = new Mock<IDictionaryRepository>();

            BoggleWordSearchService boggleWordSearchService = new BoggleWordSearchService(dictionaryRepo.Object);
            var board = "EEEOBASOOTALSANI";
            var expectedResults = Solution0Results();
            //Act
            HashSet<string> result = boggleWordSearchService.FindWordsInBoggle(board);

            //Assert
            Assert.AreEqual(expectedResults, result); 
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
    }
}
