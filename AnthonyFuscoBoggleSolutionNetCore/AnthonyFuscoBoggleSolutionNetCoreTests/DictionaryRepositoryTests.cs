using AnthonyFuscoBoggleSolutionNetCore.Data;
using NUnit.Framework;

namespace AnthonyFuscoBoggleSolutionNetCoreTests
{
    public class DictionaryRepositoryTests
    {
        [Test]
        public void GetsWordsFromFileGreaterThanThree()
        {
            //Arrange
            DictionaryRepository dictionaryRepository = new DictionaryRepository();
            
            //Act
            var words = dictionaryRepository.GetWords();

            //Assert
            Assert.IsFalse(words.Contains("AA"));
            Assert.IsFalse(words.Contains("A"));
        }
    }
}
