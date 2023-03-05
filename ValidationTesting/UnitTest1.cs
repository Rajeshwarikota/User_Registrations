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
        public void Validating_Email(string email, string expected)
        {
            Validating validate = new Validating();
            string actual = Validating.Email(email);
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

    }
}