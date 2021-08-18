using FluentAssertions;
using TechTalk.SpecFlow;

namespace AccountManagement.Tests.Steps
{
    [Binding]
    public class UserLoginToAccountSteps
    {
        private Account _account;
        private string _result;

        [Given(@"i am '(.*)' with password '(.*)'")]
        public void GivenIAmWithPassword(string username, string password)
        {
            _account = new Account(username, password);
        }

        [When(@"i try to login")]
        public void WhenITryToLogin()
        {
            _result = _account.Authenticate();
        }

        [Then(@"i should get message '(.*)'")]
        public void ThenIShouldGetMessage(string output)
        {
            _result.Should().Be(output);
        }
    }
}