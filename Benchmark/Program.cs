using App;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using Domain.Abstraction;
using Moq;
[SimpleJob(iterationCount:10)]
[MemoryDiagnoser]
public class CreateUserHandlerBenchmark
{
    private readonly Handler _handler;
    private readonly Handler.NewUserRequest _request;

    public CreateUserHandlerBenchmark()
    {
        var userRepository = new Mock<IUserRepository>();
        _handler = new Handler(userRepository.Object);
        _request = new Handler.NewUserRequest() { Data = "123" };
    }

    [Benchmark]
    public async Task<Guid> CreateUser()
    {
        return await _handler.Handle(_request);
    }
    public static void Main(string[] args)
    {
        //для уменьшения логов
        var config = ManualConfig.Create(DefaultConfig.Instance)
                .WithOptions(ConfigOptions.DisableOptimizationsValidator);

        BenchmarkRunner.Run<CreateUserHandlerBenchmark>(/*config*/);
    }
}