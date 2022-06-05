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
        public void Comparing_the_First_Name_of_User_If_Improper_throw_Exception()
        {
            //Arrange
            string firstName = "rohan";
            string expected = "FirstName is invalid";
            try
            {
                //Act
                userRegistration.ValidFirstName(firstName);
            }
            catch (RegexCustomException expection)
            {
                //Assert
                Assert.AreEqual(expected, expection.Message);
            }
        }
        //<summary>
        //uc2 : Comparing the last name of user
        //</summary>
        [Test]
        public void Comparing_the_Last_Name_of_User_If_Improper_throw_Exception()
        {
            //Arrange
            string lastName = "tare";
            string expected = "LastName is invalid";
            try
            {
                //Act
                userRegistration.ValidLastName(lastName);
            }
            catch (RegexCustomException expection)
            {
                //Assert
                Assert.AreEqual(expected, expection.Message);
            }
        }
        //<summary>
        //uc3 : Comparing the email of user
        //</summary>
        [Test]
        public void Comparing_the_EmailId_of_User_If_Improper_throw_Exception()
        {
            //Arrange
            string email = " ";
            string expected = "EmailId is invalid";
            try
            {
                //Act
                userRegistration.ValidEmail(email);
            }
            catch (RegexCustomException expection)
            {
                //Assert
                Assert.AreEqual(expected, expection.Message);
            }
        }
        //<summary>
        //uc4 : Comparing the Mobile Number of user
        //</summary>
        [Test]
        public void Comparing_the_Mobile_Number_of_User_If_Improper_throw_Exception()
        {
            //Arrange
            string mobile_Num = "9158499217";
            string expected = "Mobile Number is invalid";
            try
            {
                //Act
                userRegistration.ValidMobile(mobile_Num);
            }
            catch (RegexCustomException expection)
            {
                //Assert
                Assert.AreEqual(expected, expection.Message);
            }
        }
        //<summary>
        //uc5 : Comparing the Password of user
        //</summary>
        [Test]
        public void Comparing_the_Password_of_User_If_Improper_throw_Exception()
        {
            //Arrange
            string passWord = "rohant";
            string expected = "Password is invalid";
            try
            {
                //Act
                userRegistration.ValidPassword(passWord);
            }
            catch (RegexCustomException expection)
            {
                //Assert
                Assert.AreEqual(expected, expection.Message);
            }
        }
        //<summary>
        //uc6 : Comparing the Password of user with minimum one upper case
        //</summary>
        [Test]
        public void Comparing_the_Password_of_User_with_Minimum_One_Upper_case_If_Improper_throw_Exception()
        {
            //Arrange
            string passWord2 = "rohantare";
            string expected = "Password is invalid";
            try
            {
                //Act
                userRegistration.ValidPassword2(passWord2);
            }
            catch (RegexCustomException expection)
            {
                //Assert
                Assert.AreEqual(expected, expection.Message);
            }
        }
        //<summary>
        //uc7: Comparing the Password of user with minimum one numeric value
        //</summary>
        [Test]
        public void Comparing_the_Password_of_User_with_Minimum_One_Numeric_value_If_Improper_throw_Exception()
        {
            //Arrange
            string passWord3 = "RohanTare";
            string expected = "Password is invalid";
            try
            {
                //Act
                userRegistration.ValidPassword3(passWord3);
            }
            catch (RegexCustomException expection)
            {
                //Assert
                Assert.AreEqual(expected, expection.Message);
            }
        }
        //<summary>
        //uc8: Comparing the Password of user with exactly one special character
        //</summary>
        [Test]
        public void Comparing_the_Password_of_User_with_Exactly_One_Special_Character_If_Improper_throw_Exception()
        {
            //Arrange
            string passWord4 = "RohanTare99";
            string expected = "Password is invalid";
            try
            {
                //Act
                userRegistration.ValidPassword4(passWord4);
            }
            catch (RegexCustomException expection)
            {
                //Assert
                Assert.AreEqual(expected, expection.Message);
            }
        }
        //<summary>
        //uc9 : Comparing the All Email Samples
        //</summary>
        [Test]
        public void Comparing_the_All_Email_Samples_If_Improper_throw_Exception()
        {
            //Arrange
            string Allemail = " ";
            string expected = "Email is invalid";
            try
            {
                //Act
                userRegistration.ValidAllEmails(Allemail);
            }
            catch (RegexCustomException expection)
            {
                //Assert
                Assert.AreEqual(expected, expection.Message);
            }
        }
    }
}