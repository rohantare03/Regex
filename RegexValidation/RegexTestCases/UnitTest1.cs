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
            string expected = "First Name should not be invalid";
            try
            {
                //Act
                userRegistration.First_Name(firstName);
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
            string lastName = "tae";
            string expected = "Last Name should not be invalid";
            try
            {
                //Act                
                userRegistration.Last_Name(lastName);
            }
            catch (RegexCustomException expection)
            {
                //Assert
                Assert.AreEqual(expected, expection.Message);
            }
        }
        //<summary>
        //uc3 : Comparing the EmailId of user
        //</summary>
        [Test]
        public void Comparing_the_EmailId_of_User_If_Improper_throw_Exception()
        {
            //Arrange
            string Email_Id = "rohantare";
            string expected = "Email should not be invalid";
            try
            {
                //Act                
                userRegistration.EmailId(Email_Id);
            }
            catch (RegexCustomException expection)
            {
                //Assert
                Assert.AreEqual(expected, expection.Message);
            }
        }
        //<summary>
        //uc4 : Comparing the mobile number of user
        //</summary>
        [Test]
        public void Comparing_the_Mobile_Number_of_User_If_Improper_throw_Exception()
        {
            //Arrange
            string Mobile_num = "9158499217";
            string expected = "Mobile Number should not be invalid";
            try
            {
                //Act               
                userRegistration.Mobile(Mobile_num);
            }
            catch (RegexCustomException expection)
            {
                //Assert
                Assert.AreEqual(expected, expection.Message);
            }
        }
        //<summary>
        //uc5 : Comparing the password of user
        //</summary>
        [Test]
        public void Comparing_the_Password_of_User_If_Improper_throw_Exception()
        {
            //Arrange
            string password = " ";
            string expected = "Password should not be invalid";
            try
            {
                //Act                
                userRegistration.Validate_PassWord(password);
            }
            catch (RegexCustomException expection)
            {
                //Assert
                Assert.AreEqual(expected, expection.Message);
            }
        }
        //<summary>
        //uc6 : Comparing the password of user with minimum one upper case
        //</summary>
        [Test]
        public void Comparing_the_Password_of_User_Minimum_one_Upper_Case_If_Improper_throw_Exception()
        {
            //Arrange
            string password2 = "rohant";
            string expected = "Password should not be invalid";
            try
            {
                //Act                
                userRegistration.Validate_PassWord2(password2);
            }
            catch (RegexCustomException expection)
            {
                //Assert
                Assert.AreEqual(expected, expection.Message);
            }
        }
        //<summary>
        //uc7 : Comparing the password of user with minimum one numeric value
        //</summary>
        [Test]
        public void Comparing_the_Password_of_User_Minimum_one_Numeric_Value_If_Improper_throw_Exception()
        {
            string password3 = "RohanTare";
            string expected = "Password should not be invalid";
            try
            {
                //Act               
                userRegistration.Validate_PassWord3(password3);
            }
            catch (RegexCustomException expection)
            {
                //Assert
                Assert.AreEqual(expected, expection.Message);
            }
        }
        //<summary>
        //uc8 : Comparing the password of user with exactly one special character
        //</summary>
        [Test]
        public void Comparing_the_Password_of_User_exactly_one_Special_Character_If_Improper_throw_Exception()
        {
            string password4 = "RohanTare99";
            string expected = "Password should not be invalid";
            try
            {
                //Act                
                userRegistration.Validate_PassWord4(password4);
            }
            catch (RegexCustomException expection)
            {
                //Assert
                Assert.AreEqual(expected, expection.Message);
            }
        }
        //<summary>
        //uc9 : Comparing the Emails of all the given sample Emails
        //</summary>
        [Test]
        public void Comparing_the_Emails_of_all_the_given_Sample_Emails_If_Improper_throw_Exception() 
        {
            string allemail = "";
            string expected = "Email should not be invalid";
            try
            {
                //Act               
                userRegistration.Validate_AllEmails(allemail);
            }
            catch (RegexCustomException expection)
            {
                //Assert
                Assert.AreEqual(expected, expection.Message);
            }
        }
    }
}