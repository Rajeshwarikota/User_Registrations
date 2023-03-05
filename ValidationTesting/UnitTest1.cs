using UserRegistration;
namespace ValidationTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("Raj", "Happy")]
        [DataRow("Abc", "Happy")]
        [DataRow("ammu", "Sad")]
        [DataRow("mnu", "Sad")]
        public void ValidatingFirstName(string firstname, string expected)
        {

            Validating validate = new Validating();
            string actual = Validating.FirstName(firstname);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow("Raj", "Happy")]
        [DataRow("Abc", "Happy")]
        [DataRow("ammu", "Sad")]
        [DataRow("mnu", "Sad")]
        public void ValidatingLastName(string lastname, string expected)
        {

            Validating validate = new Validating();
            string actual = Validating.LastName(lastname);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow("abc.xyz@bl.co.in", "Happy")]
        [DataRow("abc-100@yahoo.com", "Happy")]
        [DataRow("abc@%*.com", "Sad")]
        [DataRow("abc@gmail.com.", "Sad")]
        public void Validating_Email(string emails, string expected)
        {
            Validating validate = new Validating();
            string actual = Validating.Email(emails);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow("91 9876543210", "Happy")]
        [DataRow("01 9786543521", "Happy")]
        [DataRow("919876543210", "Sad")]
        [DataRow("91 97865 43521", "Sad")]
        public void ValidatingPhoneNumber(string Number, string expected)
        {
            Validating validate = new Validating();
            string actual = Validating.PhoneNumber(Number);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow("Kraji@111", "Happy")]
        [DataRow("Xyz1&uiodLL", "Happy")]
        [DataRow("kj.5gthf", "Sad")]
        [DataRow("tdgTNDDJSK", "Sad")]
        public void Validating_Password(string password, string expected)
        {

            Validating validate = new Validating();
            string actual = Validating.Password(password);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow(new string[] { "abc.xyz@bl.co.in", "abc-100@yahoo.com,", "abc.100@yahoo.com", "abc@100yahoo.com", "abc@gmail.com.com", "abc.100@abc.com.au", "ABC1@APPLE.com," }, "Happy")]
        [DataRow(new string[] { "asc@kd@.com", "bc@gmail.com,in", "abc-100@.com,", "abc@gmail.com.", "abc@%*.com", "abc..nn@gmail.com.", "abc@%*.com", "abc@gmail.com.1a" }, "Sad")]
        public void Validating_Mutiple_Email(string[] emails, string expected)
        {

            Validating validate = new Validating();

            foreach (string s in emails)
            {
                Console.Write("\n" + s + " -");
                string actual = Validating.Email(s);
                Assert.AreEqual(expected, actual);
            }

        }
    }
}