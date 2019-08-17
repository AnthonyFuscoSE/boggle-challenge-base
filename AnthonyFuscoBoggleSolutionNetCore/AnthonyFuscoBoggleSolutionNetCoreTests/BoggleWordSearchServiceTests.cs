using System.Collections.Generic;
using System.Linq;
using AnthonyFuscoBoggleSolutionNetCore;
using AnthonyFuscoBoggleSolutionNetCore.Data;
using Moq;
using NUnit.Framework;

namespace AnthonyFuscoBoggleSolutionNetCoreTests
{
    public class BoggleWordSearchTests
    {
        [Test]
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

        [Test]
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

        [Test]
        public void Puzzle2Test()
        {
            //Arrange
            IDictionaryRepository dictionaryRepository = new DictionaryRepository();

            ITrieBuilder trieBuilder = new TrieBuilder(dictionaryRepository);

            BoggleWordSearchService boggleWordSearchService = new BoggleWordSearchService(trieBuilder);
            var board = "CEOIBAMTEHGSYPOE";
            var expectedResults = Solution2Results();

            //Act
            HashSet<string> result = boggleWordSearchService.FindWordsInBoggle(board, 4, 4);

            //only care that tries look the same. 
            var resultString = Newtonsoft.Json.JsonConvert.SerializeObject(result.OrderBy(keys => keys));
            var expectedString = Newtonsoft.Json.JsonConvert.SerializeObject(expectedResults);

            //Assert
            Assert.AreEqual(expectedString, resultString);
        }

        [Test]
        public void Puzzle3Test()
        {
            //Arrange
            IDictionaryRepository dictionaryRepository = new DictionaryRepository();

            ITrieBuilder trieBuilder = new TrieBuilder(dictionaryRepository);

            BoggleWordSearchService boggleWordSearchService = new BoggleWordSearchService(trieBuilder);
            var board = "FVKOWQIMEZTLRPBE";
            var expectedResults = Solution3Results();

            //Act
            HashSet<string> result = boggleWordSearchService.FindWordsInBoggle(board, 4, 4);

            //only care that tries look the same. 
            var resultString = Newtonsoft.Json.JsonConvert.SerializeObject(result.OrderBy(keys => keys));
            var expectedString = Newtonsoft.Json.JsonConvert.SerializeObject(expectedResults);

            //Assert
            Assert.AreEqual(expectedString, resultString);
        }

        [Test]
        public void Puzzle4Test()
        {
            //Arrange
            IDictionaryRepository dictionaryRepository = new DictionaryRepository();

            ITrieBuilder trieBuilder = new TrieBuilder(dictionaryRepository);

            BoggleWordSearchService boggleWordSearchService = new BoggleWordSearchService(trieBuilder);
            var board = "VCOEQEIAUHPTGDAD";
            var expectedResults = Solution4Results();

            //Act
            HashSet<string> result = boggleWordSearchService.FindWordsInBoggle(board, 4, 4);

            //only care that tries look the same. 
            var resultString = Newtonsoft.Json.JsonConvert.SerializeObject(result.OrderBy(keys => keys));
            var expectedString = Newtonsoft.Json.JsonConvert.SerializeObject(expectedResults);

            //Assert
            Assert.AreEqual(expectedString, resultString);
        }

        [Test]
        public void Puzzle5Test()
        {
            //Arrange
            IDictionaryRepository dictionaryRepository = new DictionaryRepository();

            ITrieBuilder trieBuilder = new TrieBuilder(dictionaryRepository);

            BoggleWordSearchService boggleWordSearchService = new BoggleWordSearchService(trieBuilder);
            var board = "RRIEZUYTVEIQOSOO";
            var expectedResults = Solution5Results();

            //Act
            HashSet<string> result = boggleWordSearchService.FindWordsInBoggle(board, 4, 4);

            //only care that tries look the same. 
            var resultString = Newtonsoft.Json.JsonConvert.SerializeObject(result.OrderBy(keys => keys));
            var expectedString = Newtonsoft.Json.JsonConvert.SerializeObject(expectedResults);

            //Assert
            Assert.AreEqual(expectedString, resultString);
        }

        [Test]
        public void Puzzle6Test()
        {
            //Arrange
            IDictionaryRepository dictionaryRepository = new DictionaryRepository();

            ITrieBuilder trieBuilder = new TrieBuilder(dictionaryRepository);

            BoggleWordSearchService boggleWordSearchService = new BoggleWordSearchService(trieBuilder);
            var board = "TMEZTTALLMQSAWFY";
            var expectedResults = Solution6Results();

            //Act
            HashSet<string> result = boggleWordSearchService.FindWordsInBoggle(board, 4, 4);

            //only care that tries look the same. 
            var resultString = Newtonsoft.Json.JsonConvert.SerializeObject(result.OrderBy(keys => keys));
            var expectedString = Newtonsoft.Json.JsonConvert.SerializeObject(expectedResults);

            //Assert
            Assert.AreEqual(expectedString, resultString);
        }

        [Test]
        public void Puzzle7Test()
        {
            //Arrange
            IDictionaryRepository dictionaryRepository = new DictionaryRepository();

            ITrieBuilder trieBuilder = new TrieBuilder(dictionaryRepository);

            BoggleWordSearchService boggleWordSearchService = new BoggleWordSearchService(trieBuilder);
            var board = "NGEREUADEFNJALLZ";
            var expectedResults = Solution7Results();

            //Act
            HashSet<string> result = boggleWordSearchService.FindWordsInBoggle(board, 4, 4);

            //only care that tries look the same. 
            var resultString = Newtonsoft.Json.JsonConvert.SerializeObject(result.OrderBy(keys => keys));
            var expectedString = Newtonsoft.Json.JsonConvert.SerializeObject(expectedResults);

            //Assert
            Assert.AreEqual(expectedString, resultString);
        }

        [Test]
        public void Puzzle8Test()
        {
            //Arrange
            IDictionaryRepository dictionaryRepository = new DictionaryRepository();

            ITrieBuilder trieBuilder = new TrieBuilder(dictionaryRepository);

            BoggleWordSearchService boggleWordSearchService = new BoggleWordSearchService(trieBuilder);
            var board = "NLOLEAPSXIMDAHRG";
            var expectedResults = Solution8Results();

            //Act
            HashSet<string> result = boggleWordSearchService.FindWordsInBoggle(board, 4, 4);

            //only care that tries look the same. 
            var resultString = Newtonsoft.Json.JsonConvert.SerializeObject(result.OrderBy(keys => keys));
            var expectedString = Newtonsoft.Json.JsonConvert.SerializeObject(expectedResults);

            //Assert
            Assert.AreEqual(expectedString, resultString);
        }

        [Test]
        public void Puzzle9Test()
        {
            //Arrange
            IDictionaryRepository dictionaryRepository = new DictionaryRepository();

            ITrieBuilder trieBuilder = new TrieBuilder(dictionaryRepository);

            BoggleWordSearchService boggleWordSearchService = new BoggleWordSearchService(trieBuilder);
            var board = "DKELBFSLOWGCOBKH";
            var expectedResults = Solution9Results();

            //Act
            HashSet<string> result = boggleWordSearchService.FindWordsInBoggle(board, 4, 4);

            //only care that tries look the same. 
            var resultString = Newtonsoft.Json.JsonConvert.SerializeObject(result.OrderBy(keys => keys));
            var expectedString = Newtonsoft.Json.JsonConvert.SerializeObject(expectedResults);

            //Assert
            Assert.AreEqual(expectedString, resultString);
        }

        [Test]
        public void Puzzle5By5Test()
        {
            //Arrange
            Mock<IDictionaryRepository> dictionaryRepositoryMock = new Mock<IDictionaryRepository>();
            dictionaryRepositoryMock.Setup(x => x.GetWords()).Returns(Solution5By5Results().ToList);
            
            ITrieBuilder trieBuilder = new TrieBuilder(dictionaryRepositoryMock.Object);

            BoggleWordSearchService boggleWordSearchService = new BoggleWordSearchService(trieBuilder);
            var board = "sabtebralnuetoenrkeseqnss";
            var expectedResults = Solution5By5Results();

            //Act
            HashSet<string> result = boggleWordSearchService.FindWordsInBoggle(board, 5, 5);

            //only care that tries look the same. 
            var resultString = Newtonsoft.Json.JsonConvert.SerializeObject(result.OrderBy(keys => keys));
            var expectedString = Newtonsoft.Json.JsonConvert.SerializeObject(expectedResults.OrderBy(keys => keys));

            //Assert
            Assert.AreEqual(expectedString, resultString);
        }

        [Test]
        [TestCase("EEEOBASOOTALSANI", 4, 4, true)]
        [TestCase("EEEOBASOOTALSANII", 4, 4, false)]
        [TestCase("EEEOB@SOOTALSANII", 4, 4, false)]
        [TestCase("EEEOB@SOOTALSANI", 4, 4, false)]
        [TestCase("EEEOBaSOOTALSANI", 4, 4, true)]
        [TestCase("EEEOBASOOTALSANICCCC", 4, 5, true)]
        [TestCase("EEEOBASOOTALSani", 4, 4, true)]
        [TestCase("EEEOBASOOTALSani", -1, -4, false)]
        [TestCase("EEEOBASOOTALSani", -1, 4, false)]

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

        [Test]
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

        private static HashSet<string> Solution2Results()
        {
            return new HashSet<string>
            {
                "ACE",
                "AGE",
                "AGES",
                "AGO",
                "AMI",
                "BAG",
                "BAGS",
                "BAH",
                "BAM",
                "BAMS",
                "BEAM",
                "BEAMS",
                "BEMA",
                "BEY",
                "CAB",
                "CAGE",
                "CAGES",
                "CAM",
                "CAME",
                "CAMEO",
                "CAMS",
                "EGO",
                "EGOS",
                "EMIT",
                "EMITS",
                "EMS",
                "EPHA",
                "EPOS",
                "GAB",
                "GAE",
                "GAM",
                "GAME",
                "GAMS",
                "GEST",
                "GHOST",
                "GOES",
                "HAE",
                "HAEM",
                "HAEMS",
                "HAG",
                "HAGS",
                "HAM",
                "HAME",
                "HAMS",
                "HAO",
                "HEBE",
                "HEP",
                "HEY",
                "HOE",
                "HOES",
                "HOG",
                "HOGS",
                "HOP",
                "HOPE",
                "HOSE",
                "HOST",
                "HYP",
                "HYPE",
                "HYPO",
                "HYPOS",
                "HYPOSTOME",
                "IMAGE",
                "IMAGES",
                "IMAGO",
                "IMAGOES",
                "IMAGOS",
                "ITS",
                "MABE",
                "MAC",
                "MACE",
                "MAE",
                "MAG",
                "MAGE",
                "MAGES",
                "MAGS",
                "MAHOE",
                "MAHOES",
                "MHO",
                "MHOS",
                "MOA",
                "MOT",
                "MOTS",
                "OES",
                "OGAM",
                "OGAMS",
                "OGHAM",
                "OGHAMS",
                "OHM",
                "OHMAGE",
                "OHMAGES",
                "OHMS",
                "OMIT",
                "OMITS",
                "OMS",
                "OPE",
                "OSE",
                "PEA",
                "PEACE",
                "PEAG",
                "PEAGE",
                "PEAGES",
                "PEAGS",
                "PEH",
                "PHAGE",
                "PHAGES",
                "POH",
                "POSE",
                "POST",
                "POSTGAME",
                "PYE",
                "SEG",
                "SEGO",
                "SMIT",
                "SOP",
                "SOPH",
                "SOPHY",
                "STIME",
                "STOA",
                "STOAE",
                "STOMA",
                "TIME",
                "TOE",
                "TOEA",
                "TOM",
                "TOME",
                "TOMS",
                "YEA",
                "YEAH",
                "YEH",
                "YEP"
            };
        }

        private static HashSet<string> Solution3Results()
        {
            return new HashSet<string>
            {
                "BEL",
                "BELT",
                "BET",
                "BLET",
                "BLITE",
                "BLITZ",
                "ELM",
                "KILT",
                "KIT",
                "KITE",
                "KOI",
                "LET",
                "LIMO",
                "LIT",
                "LITE",
                "MIL",
                "MILE",
                "MILT",
                "MITE",
                "MOIL",
                "OIL",
                "OMIT",
                "PER",
                "PEW",
                "PREZ",
                "REP",
                "REPTILE",
                "TEL",
                "TIL",
                "TILE",
                "VILE",
                "VIM",
                "WEPT",
                "ZIT"
            };
        }

        private static HashSet<string> Solution4Results()
        {
            return new HashSet<string>
            {
                "AIT",
                "APE",
                "APT",
                "ATAP",
                "CEP",
                "CIAO",
                "COAPT",
                "COAT",
                "COATI",
                "DAD",
                "DAH",
                "DAP",
                "DATA",
                "DUE",
                "DUG",
                "EAT",
                "EPHA",
                "EPIC",
                "GHAT",
                "GHI",
                "HAD",
                "HAP",
                "HAPTIC",
                "HAT",
                "HEP",
                "HEPATIC",
                "HEPTAD",
                "HIC",
                "HIE",
                "HIP",
                "HIT",
                "HUE",
                "HUG",
                "ICE",
                "OAT",
                "PAD",
                "PAH",
                "PAT",
                "PATIO",
                "PEC",
                "PEH",
                "PHAT",
                "PHATIC",
                "PHI",
                "PIA",
                "PIC",
                "PICE",
                "PIE",
                "PIT",
                "PITA",
                "TAD",
                "TAE",
                "TAO",
                "TAP",
                "TAPA",
                "TAPE",
                "TIC",
                "TIE",
                "TIP",
                "UGH"
            };
        }

        private static HashSet<string> Solution5Results()
        {
            return new HashSet<string>
            {
                "EYE",
                "EYES",
                "EYRIE",
                "OES",
                "OSE",
                "RITE",
                "RUE",
                "RUES",
                "RYE",
                "RYES",
                "SEI",
                "SIEUR",
                "SIT",
                "SITE",
                "TIE",
                "TIES",
                "TIS",
                "TYE",
                "TYES",
                "VOE",
                "VOES",
                "YES",
                "YET",
                "YETI",
                "YETIS",
                "YIRR"
            };
        }

        private static HashSet<string> Solution6Results()
        {
            return new HashSet<string>
            {
                "ALE",
                "ALMA",
                "ALMAS",
                "ALS",
                "ALT",
                "AMA",
                "AMAS",
                "AMAZE",
                "ATE",
                "ATMA",
                "ATT",
                "AWL",
                "EASY",
                "EAT",
                "ELS",
                "ETA",
                "ETAS",
                "LAM",
                "LAMA",
                "LAMAS",
                "LAME",
                "LAS",
                "LAT",
                "LATE",
                "LAW",
                "LAZE",
                "LEA",
                "LEAS",
                "LET",
                "LEZ",
                "MAE",
                "MALE",
                "MALT",
                "MAMA",
                "MAS",
                "MAT",
                "MATE",
                "MATT",
                "MAW",
                "MAZE",
                "MEAL",
                "MEALS",
                "MEAT",
                "MEL",
                "MELS",
                "MET",
                "META",
                "METAL",
                "METALS",
                "QAT",
                "SAE",
                "SAL",
                "SALE",
                "SAME",
                "SAT",
                "SATE",
                "SATEM",
                "SLAM",
                "SLAT",
                "SLATE",
                "TAE",
                "TAEL",
                "TAELS",
                "TALE",
                "TAM",
                "TAMAL",
                "TAME",
                "TAS",
                "TEA",
                "TEAL",
                "TEALS",
                "TEAM",
                "TEAS",
                "TEL",
                "TELA",
                "TELS",
                "ZEAL",
                "ZEALS",
                "ZETA",
                "ZETAS"
            };
        }

        private static HashSet<string> Solution7Results()
        {
            return new HashSet<string>
            {
                "AFAR",
                "AGE",
                "AGED",
                "AGEE",
                "AGER",
                "AGUE",
                "ALE",
                "ALEE",
                "ALEF",
                "ALFA",
                "ALL",
                "AND",
                "ARE",
                "AUGER",
                "DAG",
                "DARE",
                "DEAF",
                "DEAFEN",
                "DEAN",
                "DEAR",
                "DRAG",
                "DRAGEE",
                "DREG",
                "EAR",
                "EAU",
                "EEL",
                "EGAD",
                "EGER",
                "ELF",
                "ELL",
                "ENG",
                "ERA",
                "FAD",
                "FADE",
                "FADER",
                "FAG",
                "FALL",
                "FAN",
                "FAR",
                "FARD",
                "FARE",
                "FARED",
                "FAUN",
                "FEAL",
                "FEE",
                "FEEL",
                "FELL",
                "FEN",
                "FEU",
                "FEUAR",
                "FEUED",
                "FLEA",
                "FLEE",
                "FUEL",
                "FUG",
                "FUN",
                "FUND",
                "GAD",
                "GAE",
                "GAED",
                "GAN",
                "GANDER",
                "GAR",
                "GAUN",
                "GEAR",
                "GED",
                "GEE",
                "GEN",
                "GENU",
                "GENUA",
                "GNU",
                "GUAN",
                "GUAR",
                "GUARD",
                "GUN",
                "JADE",
                "JAG",
                "JAGER",
                "JAR",
                "LEA",
                "LEAF",
                "LEAFAGE",
                "LEE",
                "LEU",
                "NAE",
                "NAG",
                "NARD",
                "NEE",
                "NUN",
                "RAD",
                "RAG",
                "RAGE",
                "RAGED",
                "RAGEE",
                "RAJ",
                "RAN",
                "RAND",
                "READ",
                "RED",
                "REDAN",
                "REG",
                "UNAGED",
                "UNDE",
                "UNDER",
                "UNDERAGE"
            };
        }

        private static HashSet<string> Solution8Results()
        {
            return new HashSet<string>
            {
                "AIM",
                "AIMS",
                "AIR",
                "AIRMAN",
                "ALE",
                "ALEXIA",
                "ALP",
                "ALPS",
                "AMI",
                "AMIA",
                "AMIE",
                "AMIR",
                "AMP",
                "AMPLE",
                "AMPS",
                "ANE",
                "AXAL",
                "AXE",
                "AXEL",
                "AXIAL",
                "DRIP",
                "DRIPS",
                "ELAN",
                "EXAM",
                "EXAMS",
                "GRIM",
                "GRIP",
                "GRIPMAN",
                "GRIPS",
                "HAIR",
                "HIE",
                "HIM",
                "HIP",
                "HIPS",
                "IMP",
                "IMPALE",
                "IMPANEL",
                "IMPS",
                "LAIR",
                "LAIRD",
                "LAIRDS",
                "LAM",
                "LAMIA",
                "LAMP",
                "LAMPS",
                "LAMS",
                "LANE",
                "LAP",
                "LAPS",
                "LAX",
                "LEA",
                "LEAN",
                "LEAP",
                "LEAPS",
                "LEI",
                "LEX",
                "LOAM",
                "LOAMS",
                "LOAN",
                "LOP",
                "LOPS",
                "MAE",
                "MAIR",
                "MALE",
                "MAN",
                "MANE",
                "MAP",
                "MAPLE",
                "MAPS",
                "MAX",
                "MAXI",
                "MIEN",
                "MIR",
                "MIX",
                "NAE",
                "NAM",
                "NAOS",
                "NAP",
                "NAPS",
                "NEAP",
                "NEAPS",
                "OLE",
                "OLEA",
                "OPAL",
                "OPS",
                "PAIR",
                "PAL",
                "PALE",
                "PAM",
                "PAMS",
                "PAN",
                "PANE",
                "PANEL",
                "PAX",
                "PIA",
                "PIAL",
                "PIAN",
                "PIE",
                "PIMA",
                "PIX",
                "PIXEL",
                "PLAN",
                "PLANE",
                "PLEA",
                "PLENA",
                "POL",
                "POLE",
                "POLEAX",
                "POLS",
                "PSOAE",
                "PSOAI",
                "RIA",
                "RIAL",
                "RIEL",
                "RIM",
                "RIMPLE",
                "RIMS",
                "RIP",
                "RIPS",
                "SLOP",
                "SOAP",
                "SOL",
                "SOLA",
                "SOLAN",
                "SOLE",
                "SOLEI",
                "SOP",
                "SPA",
                "SPAE",
                "SPALE",
                "SPAN",
                "SPIEL"
            };
        }

        private static HashSet<string> Solution9Results()
        {
            return new HashSet<string>
            {
                "BOB",
                "BOO",
                "BOOB",
                "BOW",
                "BOWS",
                "BOWSE",
                "CLEF",
                "CLEFS",
                "EFS",
                "ELL",
                "ELLS",
                "ELS",
                "FELL",
                "FELLS",
                "FOB",
                "KEF",
                "KEFS",
                "LEK",
                "LEKS",
                "OWSE",
                "SEL",
                "SELL",
                "SWOB",
                "WOO",
                "WOOF",
                "WOOFS"
            };
        }

        private static HashSet<string> Solution5By5Results()
        {
            return new HashSet<string>
            {
                "ABALONE",
                "ABALONES",
                "ABATE",
                "ABATER",
                "ABATERS",
                "ABATES",
                "ABET",
                "ABLATE",
                "ABLATES",
                "ABLE",
                "ABLES",
                "ALEE",
                "ALES",
                "ALOE",
                "ALOES",
                "ALONE",
                "ALTER",
                "ALTERS",
                "ALTO",
                "ALTOS",
                "ARABLE",
                "ARABLES",
                "ARBS",
                "AREA",
                "AREAL",
                "ARETE",
                "ARETES",
                "ARTAL",
                "ARTLESS",
                "ATES",
                "ATONE",
                "ATONES",
                "BAAL",
                "BAAS",
                "BABE",
                "BABU",
                "BALE",
                "BALEENS",
                "BALES",
                "BARB",
                "BARBER",
                "BARBET",
                "BARBS",
                "BARE",
                "BARER",
                "BARS",
                "BARTER",
                "BATE",
                "BATELESS",
                "BATES",
                "BEAR",
                "BEARABLENESSES",
                "BEARS",
                "BEAT",
                "BEATEN",
                "BERATE",
                "BERK",
                "BERKS",
                "BETA",
                "BLARE",
                "BLAT",
                "BLATE",
                "BLATER",
                "BLEE",
                "BLESS",
                "BLESSES",
                "BLOAT",
                "BLOATER",
                "BLOATERS",
                "BLOKE",
                "BLOKES",
                "BLOT",
                "BRAE",
                "BRALESS",
                "BRAS",
                "BRAT",
                "BREN",
                "BRUNET",
                "BURET",
                "BURK",
                "BURKS",
                "BURN",
                "BURNER",
                "BURNERS",
                "BURNET",
                "BURNS",
                "BURS",
                "BURSA",
                "EARS",
                "EATEN",
                "EKES",
                "ELATE",
                "ELATER",
                "ELATERS",
                "ELATES",
                "ENURE",
                "ERKS",
                "ERNE",
                "ESES",
                "ESKER",
                "ESKERS",
                "ESSE",
                "ESSES",
                "ETALON",
                "KEEL",
                "KEEN",
                "KENS",
                "KERN",
                "KERNS",
                "KETA",
                "KETE",
                "KNEE",
                "KNEEL",
                "KNEES",
                "KOSS",
                "KOSSES",
                "LAER",
                "LARS",
                "LATE",
                "LATER",
                "LEEK",
                "LEEKS",
                "LEES",
                "LENES",
                "LENT",
                "LESS",
                "LESSEN",
                "LESSENS",
                "LESSES",
                "LOKE",
                "LOKES",
                "LONE",
                "LOSE",
                "LOSES",
                "LOSS",
                "LOSSES",
                "LOTA",
                "LOTE",
                "LOTES",
                "NEAL",
                "NEAR",
                "NEARS",
                "NEAT",
                "NEATEN",
                "NEATNESS",
                "NEATNESSES",
                "NEON",
                "NERK",
                "NERKS",
                "NESS",
                "NESSES",
                "NETE",
                "NOEL",
                "NOES",
                "NOLE",
                "NOLES",
                "NOSE",
                "NOSES",
                "NOTA",
                "NOTE",
                "NOTER",
                "NOTES",
                "NURS",
                "OARS",
                "OLES",
                "ONES",
                "OSES",
                "RALE",
                "RALES",
                "RATE",
                "RATER",
                "RATES",
                "RATO",
                "RATOS",
                "REAL",
                "REALNESS",
                "REALNESSES",
                "REAR",
                "REARS",
                "REATE",
                "REATES",
                "REKE",
                "REKES",
                "RETABLE",
                "RETABLES",
                "RETE",
                "RETES",
                "RUNE",
                "SABATON",
                "SABE",
                "SABER",
                "SABLE",
                "SABLES",
                "SABRA",
                "SABRE",
                "SEEK",
                "SEEKER",
                "SEEKS",
                "SEEL",
                "SEEN",
                "SEES",
                "SENS",
                "SENT",
                "SESS",
                "SETA",
                "SETAE",
                "SETAL",
                "SKEE",
                "SKEEN",
                "SKEES",
                "SKER",
                "SKERS",
                "SKET",
                "SNEE",
                "SNEES",
                "SOAR",
                "SOARE",
                "SOARER",
                "SOARS",
                "SOKE",
                "SOKES",
                "SOLA",
                "SOLAR",
                "SOLARS",
                "SOLE",
                "SONE",
                "TABARET",
                "TABLE",
                "TABLES",
                "TABLET",
                "TALE",
                "TALENT",
                "TALES",
                "TALON",
                "TARA",
                "TARAS",
                "TARE",
                "TARS",
                "TART",
                "TARTER",
                "TATE",
                "TATER",
                "TATERS",
                "TATES",
                "TEAL",
                "TEAR",
                "TEARS",
                "TEAT",
                "TEEL",
                "TEEN",
                "TEES",
                "TELE",
                "TELES",
                "TELESES",
                "TENE",
                "TENES",
                "TENS",
                "TERN",
                "TERNE",
                "TERNES",
                "TERNS",
                "TOES",
                "TOKE",
                "TOKEN",
                "TOKENS",
                "TOKER",
                "TOKES",
                "TOLA",
                "TOLAR",
                "TOLARS",
                "TOLE",
                "TOLES",
                "TONE",
                "TONES",
                "TOSE",
                "TOSES",
                "TOSS",
                "TOSSEN",
                "TOSSES",
                "TREAT",
                "TREK",
                "TREKS",
                "TRUE",
                "TRUER",
                "UREA",
                "UREAL"
            };
        }
    }
}
