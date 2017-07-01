namespace Fibon.Messages.Events
{
    public class ValueCalculatedEvent : IEvent
    {
        public int Number { get; set; }

        public int Value { get; set; }

        public ValueCalculatedEvent(int number, int value)
        {
            Number = number;
            Value = value;
        }
    }
}