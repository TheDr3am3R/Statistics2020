namespace Avarage{
    class Statistics    {
        public double avg { get; private set; } = 0.0;
        public int count { get; private set; } = 0;

        

        public void OLAvg(double number){
            this.count++;
            this.avg = this.avg + (1/count)*(number-this.avg);
        }

    }


}
