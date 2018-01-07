namespace _7_Structures_and_Enum_s
{
    public struct Train
    {
        public string StartPoint { get; }
        public int TrainNumber { get; }
        public int Time { get; }



        public Train(string startPoint, int trainNumber, int time)

        {
            this.StartPoint = startPoint;
            this.TrainNumber = trainNumber;
            this.Time = time;
        }

        public Train(string startPiont) :
            this(startPiont, 0, 0)
        {
        }

        public Train(string startPoint, int trainNumber) :
            this(startPoint, trainNumber, 0)
        {

        }


    }
}