using Sample.Logging;

namespace Sample.Employees
{
    public class EmployeeService
    {
        private IEmployeeRepository _repository;
        private readonly ILogger _logger;
        public EmployeeService(IEmployeeRepository repository, ILogger logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public void RegisterEmployee(string firstname, string lastname)
        {
            var employee= new Employee()
            {
                Firstname = firstname,
                Lastname = lastname,
            };
            _repository.Create(employee);
            _logger.Info($"{firstname} {lastname} - registered successfully");
        }
    }
}