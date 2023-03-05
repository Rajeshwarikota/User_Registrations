using UserRegistration;
namespace ValidationTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("Raj", "Happy")]
        [DataRow("ammu", "Sad")]
        [DataRow(null, "Firstname is invalid")]
        public void ValidatingFirstName(string firstname, string expected)
        {
            try
            {
                string actual = Validating.FirstName(firstname);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, expected);
            }
        }


        [TestMethod]
        [DataRow("Raj", "Happy")]
        [DataRow("ammu", "Sad")]
        [DataRow(null, "Lastname is invalid")]
        public void ValidatingLaststName(string lastname, string expected)
        {
            try
            {
                string actual = Validating.LastName(lastname);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, expected);
            }
        }

        [TestMethod]
        [DataRow("abc.xyz@bl.co.in", "Happy")]
        [DataRow("abc@%*.com", "Sad")]
        [DataRow(null, "Email is invalid")]
        public void ValidatingEmail(string email, string expected)
        {
            try
            {
                string actual = Validating.Email(email);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, expected);
            }
        }
        [TestMethod]
        [DataRow("91 9876543210", "Happy")]
        [DataRow("919876543210", "Sad")]
        [DataRow(null, "PhoneNumber is invalid")]
        public void ValidatingPhoneNumber(string Number, string expected)
        {
            try
            {
                string actual = Validating.PhoneNumber(Number);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, expected);
            }
        }
        [TestMethod]
        [DataRow("Kraji@111", "Happy")]
        [DataRow("kj.5gthf", "Sad")]
        [DataRow(null, "Password is invalid")]
        public void ValidatingPassword(string password, string expected)
        {
            try
            {
                string actual = Validating.Password(password);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, expected);
            }
        }
        [TestMethod]
        [DataRow(new string[] { "abc.xyz@bl.co.in", "abc-100@yahoo.com,", "abc.100@yahoo.com", "abc@100yahoo.com", "abc@gmail.com.com", "abc.100@abc.com.au", "ABC1@APPLE.com," }, "Happy")]
        [DataRow(new string[] { "asc@kd@.com", "bc@gmail.com,in", "abc-100@.com,", "abc@gmail.com.", "abc@%*.com", "abc..nn@gmail.com.", "abc@%*.com", "abc@gmail.com.1a" }, "Sad")]
        public void Validating_Mutiple_Email(string[] email, string expected)
        {

            Validating validate = new Validating();

            foreach (string s in email)
            {
                Console.Write("\n" + s + " -");
                string actual = Validating.Email(s);
                Assert.AreEqual(expected, actual);
            }

        }
    }
}