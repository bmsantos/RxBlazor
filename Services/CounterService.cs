
[Injectable(typeof(ICounterService))]
public class CounterService : ICounterService {
  private readonly IMessageService _messageService;

  public int count { get; set; } = 0;

  public void Increment() => _messageService.SendMessage(new StringMessage($"CounterService:Increment:{++count}"));

  public CounterService(IMessageService messageService) => _messageService = messageService;
}