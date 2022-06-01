using NUnit.Framework;
using RegexValidation;

namespace RegexTestCases
{
    public class Tests
    {
        UserRegistration userRegistration; 
        [SetUp]
        public void Setup()
        {
            userRegistration = new UserRegistration();
        }
        //<summary>
        //uc1 : Comparing the first name of user
        //</summary>
        [Test]
        public void Comparing_the_First_Name_of_User()
        {
            //Arrange
            string firstName = "Rohan";
            userRegistration = new UserRegistration();
            //Act
            string expected = "Rohan";
            string actual = userRegistration.Validate_FirstName(firstName);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //<summary>
        //uc2 : Comparing the last name of user
        //</summary>
        [Test]
        public void Comparing_the_Last_Name_of_User()
        {
            //Arrange
            string lastName = "Tare";
            userRegistration = new UserRegistration();
            //Act
            string expected = "Tare";
            string actual = userRegistration.Validate_LastName(lastName);
            //Assert
            Assert.AreEqual(expected, actual);
        }
      
    }
}