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
            DictionaryRepository test = new DictionaryRepository();
            
            //Act
            var words = test.GetWords();

            //Assert
            Assert.IsFalse(words.Contains("AA"));
            Assert.IsFalse(words.Contains("A"));
        }
    }
}
