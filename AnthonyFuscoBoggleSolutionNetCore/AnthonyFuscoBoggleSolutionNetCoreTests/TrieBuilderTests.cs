using System.Collections.Generic;
using AnthonyFuscoBoggleSolutionNetCore;
using AnthonyFuscoBoggleSolutionNetCore.Data;
using AnthonyFuscoBoggleSolutionNetCore.Models;
using Moq;
using NUnit.Framework;

namespace AnthonyFuscoBoggleSolutionNetCoreTests
{
    public class TrieBuilderTests
    {
        [Test]
        public void BuildSmallTrieIsValid()
        {
            //Arrange
            var smallWordList = new List<string> {"Apple", "Apples", "Ape", "Cat"};
            Mock<IDictionaryRepository> dictionaryRepo = new Mock<IDictionaryRepository>();
            dictionaryRepo.Setup(x => x.GetWords()).Returns(smallWordList);

            TrieBuilder trieBuilder = new TrieBuilder(dictionaryRepo.Object);
            var expectedResults = Factory.CreateTrieList();
            expectedResults.Add(new Trie
            {
                Value = 'A', 
                ValidWord = false,
                Children = new List<ITrie>
                {
                    new Trie
                    {
                        Value = 'P',
                        ValidWord = false,
                        Children = new List<ITrie>
                        {
                            new Trie
                            {
                                Value = 'P',
                                ValidWord = false,
                                Children = new List<ITrie>
                                {
                                    new Trie
                                    {
                                        Value = 'L',
                                        ValidWord = false,
                                        Children = new List<ITrie>
                                        {
                                            new Trie
                                            {
                                                Value = 'E',
                                                ValidWord = true,
                                                Children = new List<ITrie>
                                                {
                                                    new Trie
                                                    {
                                                        Value = 'S',
                                                        ValidWord = true,
                                                        Children = new List<ITrie>()
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            },
                            new Trie
                            {
                                Value = 'E',
                                ValidWord = true,
                                Children = new List<ITrie>()
                            }
                        }
                    }
                }
            });
            expectedResults.Add(new Trie
            {
                Value = 'C',
                ValidWord = false,
                Children = new List<ITrie>
                {
                    new Trie
                    {
                        Value = 'A',
                        ValidWord = false,
                        Children = new List<ITrie>
                        {
                            new Trie
                            {
                                Value = 'T',
                                ValidWord = true,
                                Children = new List<ITrie>()
                            }
                        }
                    }
                }
            });

            //Act
            var result = trieBuilder.BuildTrie();

            //only care that tries look the same. 
            var resultString = Newtonsoft.Json.JsonConvert.SerializeObject(result);
            var expectedString = Newtonsoft.Json.JsonConvert.SerializeObject(expectedResults);

            //Assert
            Assert.AreEqual(expectedString, resultString); 
        }
    }
}
