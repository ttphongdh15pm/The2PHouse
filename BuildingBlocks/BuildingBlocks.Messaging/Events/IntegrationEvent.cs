namespace BuildingBlocks.Messaging.Events
{
    public record IntegrationEvent
    {
        public Guid Id => Guid.CreateVersion7();
        public DateTime OccurredOn => DateTime.Now;
        public string EventType => GetType().AssemblyQualifiedName!;
    }
}
