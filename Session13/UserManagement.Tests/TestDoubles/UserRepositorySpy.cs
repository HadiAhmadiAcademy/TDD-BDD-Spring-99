namespace UserManagement.Tests.TestDoubles
{
    public class UserRepositorySpy : IUserRepository
    {
        private User _user;
        private int _callNumbers;
        public void Save(User user)
        {
            this._user = user;
            _callNumbers++;
        }

        public User GetSavedUser() => _user;        //retrieval Interface
        public int GetNumberOfSavedUsers => _callNumbers;
    }
}