namespace WebApi.MultipleImpInterfaces
{

    public delegate IService ServiceResolver(string key);

    public interface IService {
        string Hello();
    }
    public class ServiceA : IService {
        public string Hello() {
            return "A";
        }
    }
    public class ServiceB : IService {
        public string Hello()
        {
            return "B";
        }
    }
    public class ServiceC : IService {
        public string Hello()
        {
            return "C";
        }
    }
}
