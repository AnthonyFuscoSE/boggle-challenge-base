using System;
using AnthonyFuscoBoggleSolution.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BoggleSolutionTests
{
    [TestClass]
    public class DictionaryRepositoryTests
    {
        [TestMethod]
        public void GetsWordsFromFileGreaterThanThree()
        {
            //Arrange
            DictionaryRepository dictionaryRepository = new DictionaryRepository();
            
            //Act
            var words = dictionaryRepository.GetWords();

            //Assert
            Assert.IsFalse(words.Contains("AA"));
            Assert.IsFalse(words.Contains("A"));
            Assert.IsTrue(words.Count > 0);
        }
    }
}
