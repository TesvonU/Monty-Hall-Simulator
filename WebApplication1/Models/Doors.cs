namespace WebApplication1.Models
{
    public class Doors
    {
        private bool door1 = false;
        private bool door2 = false;
        private bool door3 = false;
        
        private Random random = new Random();
        public Doors()
        {

            int carDoor = random.Next(0, 3);
            
            switch (carDoor)
            {
                case 0:
                    door1 = true;
                    break;

                case 1:
                    door2 = true;
                    break;

                case 2:
                    door3 = true;
                    break;
            }

        }

    }
}
