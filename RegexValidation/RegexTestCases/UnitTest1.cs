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
            string actual = userRegistration.Validate_EmailId(Email_Id);
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
            string actual = userRegistration.Validate_Mobile(Mobile_Num);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //<summary>
        //uc5 : Comparing the password of user
        //</summary>
        [Test]
        public void Comparing_the_Password_of_User()
        {
            //Arrange
            string Password = "rohan99tare";
            userRegistration = new UserRegistration();
            //Act
            string expected = "rohan99tare";
            string actual = userRegistration.Validate_PassWord(Password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //<summary>
        //uc6 : Comparing the password of user with minimum one upper case
        //</summary>
        [Test]
        public void Comparing_the_Password_of_User_Minimum_one_Upper_Case()
        {
            //Arrange
            string Password2 = "Rohan99tare";
            userRegistration = new UserRegistration();
            //Act
            string expected = "Rohan99tare";
            string actual = userRegistration.Validate_PassWord2(Password2);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}