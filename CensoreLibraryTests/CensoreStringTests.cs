using System;
using CensoreLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CensoreLibraryTests
{
    [TestClass]
    public class CensoreStringTests
    {
        CensoreString obj = new CensoreString();
        /// <summary>
        /// метод без цензурирования 
        /// </summary>
        [TestMethod]
        public void Censore_NoRedisca_ReturnNoStars()
        {
            //Arrange
            string stringEntry = "Какой замечательный сегодня день!";
            string expected = "Какой замечательный сегодня день!";
            //Act
            string actual = obj.Censore(stringEntry);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// метод цензуры редиски в нижнем регистре
        /// </summary>
        [TestMethod]
        public void Censore_LowerRedisca_ReturnCensoredRedisca()
        {
            //Arrange
            string stringEntry = "Я не сдал экзамен по вождению... Вот же редиска!";
            string expected = "Я не сдал экзамен по вождению... Вот же *******!";
            //Act
            string actual = obj.Censore(stringEntry);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// метод цензуры редиски в верхнем регистре
        /// </summary>
        [TestMethod]
        public void Censore_UpperRedisca_ReturnCensoredRedisca()
        {
            //Arrange
            string stringEntry = "Посмотри какая у меня замечательная РЕДИСКА!";
            string expected = "Посмотри какая у меня замечательная *******!";
            //Act
            string actual = obj.Censore(stringEntry);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// метод цензуры редиски в совмещенном регистре
        /// </summary>
        [TestMethod]
        public void Censore_UpperAndLowerRedisca_ReturnCensoredRedisca()
        {
            //Arrange
            string stringEntry = "Я пьяный словно РеДиСКА";
            string expected = "Я пьяный словно *******";
            //Act
            string actual = obj.Censore(stringEntry);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// метод цензуры редиски несколько раз
        /// </summary>
        [TestMethod]
        public void Censore_LowerRediscaManyTimes_ReturnCensoredRedisca()
        {
            //Arrange
            string stringEntry = "Сегодня моя редиска сделала редиска и пошла на редиска";
            string expected = "Сегодня моя ******* сделала ******* и пошла на *******";
            //Act
            string actual = obj.Censore(stringEntry);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// метод цензуры редиски несколько раз с совмещенным регистром
        /// </summary>
        [TestMethod]
        public void Censore_LowerAndUpperRediscaManyTimes_ReturnCensoredRedisca()
        {
            //Arrange
            string stringEntry = "Сегодня моя редиска сделала РЕДИСКА и пошла на РеДИскА";
            string expected = "Сегодня моя ******* сделала ******* и пошла на *******";
            //Act
            string actual = obj.Censore(stringEntry);
            //Assert
            Assert.AreEqual(expected, actual);
        }


        //блок с тестами метода на цензуру своего слова

        /// <summary>
        /// метод без цензурирования со своим словом
        /// </summary>
        [TestMethod]
        public void CensoreWithEntry_NoWord_ReturnNoStars()
        {
            //Arrange
            string stringEntry = "Какой замечательный сегодня день!";
            string wordToCensore = "привет";
            string expected = "Какой замечательный сегодня день!";
            //Act
            string actual = obj.CensoreWithEntry(stringEntry, wordToCensore);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// метод цензуры слова в нижнем регистре
        /// </summary>
        [TestMethod]
        public void CensoreWithEntry_LowerWord_ReturnCensoredWord()
        {
            //Arrange
            string stringEntry = "Я не люблю рыбу";
            string wordToCensore = "рыбу";
            string expected = "Я не люблю ****";
            //Act
            string actual = obj.CensoreWithEntry(stringEntry, wordToCensore);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// метод цензуры слова в верхнем регистре
        /// </summary>
        [TestMethod]
        public void CensoreWithEntry_UpperWord_ReturnCensoredWord()
        {
            //Arrange
            string stringEntry = "Никогда не чувствовал запах БЕНЗИНА";
            string wordToCensore = "бензина";
            string expected = "Никогда не чувствовал запах *******";
            //Act
            string actual = obj.CensoreWithEntry(stringEntry, wordToCensore);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// метод цензуры слова в совмещенном регистре
        /// </summary>
        [TestMethod]
        public void CensoreWithEntry_UpperAndLowerWord_ReturnCensoredWord()
        {
            //Arrange
            string stringEntry = "У него большой КишеЧНИК";
            string wordToCensore = "кишечник";
            string expected = "У него большой ********";
            //Act
            string actual = obj.CensoreWithEntry(stringEntry, wordToCensore);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// метод цензуры слова несколько раз
        /// </summary>
        [TestMethod]
        public void CensoreWithEntry_LowerWordManyTimes_ReturnCensoredWord()
        {
            //Arrange
            string stringEntry = "Мой кот сегодня пошел на рыбалку, у меня замечательный кот!";
            string wordToCensore = "кот";
            string expected = "Мой *** сегодня пошел на рыбалку, у меня замечательный ***!";
            //Act
            string actual = obj.CensoreWithEntry(stringEntry, wordToCensore);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// метод цензуры слова несколько раз с совмещенным регистром
        /// </summary>
        [TestMethod]
        public void CensoreWithEntry_LowerAndUpperWordManyTimes_ReturnCensoredWord()
        {
            //Arrange
            string stringEntry = "Каждый ДУМает в меру своей испорченности. Он не думает. Она тоже не ДУМАЕТ, она не умеет";
            string wordToCensore = "думает";
            string expected = "Каждый ****** в меру своей испорченности. Он не ******. Она тоже не ******, она не умеет";
            //Act
            string actual = obj.CensoreWithEntry(stringEntry, wordToCensore);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
