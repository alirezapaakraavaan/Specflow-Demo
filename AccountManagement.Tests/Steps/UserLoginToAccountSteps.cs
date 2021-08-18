using System.Linq;
using FluentAssertions;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace AccountManagement.Tests.Steps
{
    [Binding]
    public class UserLoginToAccountSteps
    {
        private Account _account;
        private string _result;
        private DataStore _store;

        [When(@"i try to login")]
        public void WhenITryToLogin()
        {
            _result = _account.Authenticate(_store);
        }

        [Given(@"i am (.*) with password (.*)")]
        public void GivenIAmWithPassword(string username, string password)
        {
            _account = new Account(username, password);
        }

        [Given(@"the following users are already available")]
        public void GivenTheFollowingUsersAreAlreadyAvailable(Table table)
        {
            //var account = table.CreateInstance<Account>();
            var accounts = table.CreateSet<Account>().ToList();
            _store = new DataStore(accounts);
        }

        [Then(@"i should get message (.*)")]
        public void ThenIShouldGetMessage(string output)
        {
            _result.Should().Be(output);
        }
    }
}