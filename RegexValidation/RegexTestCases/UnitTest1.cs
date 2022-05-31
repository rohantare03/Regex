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
            string actual = userRegistration.Last_Name(lastName);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //<summary>
        //uc3 : Comparing the EmailId of user
        //</summary>
        [Test]
        public void Comparing_the_EmailId_of_User()
        {
            //Arrange
            string Email_Id = "rohantare310@gmail.com";
            userRegistration = new UserRegistration();
            //Act
            string expected = "rohantare310@gmail.com";
            string actual = userRegistration.EmailId(Email_Id);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //<summary>
        //uc4 : Comparing the mobile number of user
        //</summary>
        [Test]
        public void Comparing_the_Mobile_Number_of_User()
        {
            //Arrange
            string Mobile_Num = "91 9158499217";
            userRegistration = new UserRegistration();
            //Act
            string expected = "91 9158499217";
            string actual = userRegistration.Mobile(Mobile_Num);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}