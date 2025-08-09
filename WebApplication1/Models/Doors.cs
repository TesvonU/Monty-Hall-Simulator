namespace WebApplication1.Models
{
    public class Doors
    {
        private bool door1 = false;
        private bool door2 = false;
        private bool door3 = false;
        private int selectedDoor1;
        private int revealedDoor;
        private int selectedDoor2;
        private bool switched;
        private bool won;


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

        public void SelectDoor1(int selected) //sets which door was picked and which was opened
        {
            selectedDoor1 = selected;
            bool carSelected = false;
            int coin = random.Next(0, 2);
            switch (selected)
            {
                case 0:
                    if (door1)
                    {
                        carSelected = true;
                        if (coin == 0)
                        {
                            revealedDoor = 1;
                        }
                        else
                        {
                            revealedDoor = 2;
                        }
                        
                    }
                        break;

                case 1:
                    if (door2)
                    {
                        carSelected = true;
                        if (coin == 0)
                        {
                            revealedDoor = 0;
                        }
                        else
                        {
                            revealedDoor = 2;
                        }
                    }
                    break;

                case 2:
                    if (door3)
                    {
                        carSelected = true;
                        revealedDoor = coin;
                    }
                    break;
            }
            if (!carSelected)
            {
                if (!door1 && selected != 0)
                {
                    revealedDoor = 0;
                }
                if (!door2 && selected != 1)
                {
                    revealedDoor = 1;
                }
                if (!door3 && selected != 2)
                {
                    revealedDoor = 2;
                }
            }
            return;
        }

        public void SelectDoor2(int selected)
        {
            selectedDoor2 = selected;
            if (selected == selectedDoor1)
            {
                switched = false;
            }
            else
            {
                switched = true;
            }
            won = false;
            switch (selected)
            {
                case 0:
                    if (door1)
                    {
                        won = true;
                    }
                    break;
                case 1:
                    if (door2)
                    {
                        won = true;
                    }
                    break;
                case 2:
                    if (door3)
                    {
                        won = true;
                    }
                    break;
            }
        }

        public int GetFirstSelection()
        {
            return selectedDoor1;
        }

        public int GetRevealed()
        {
            return revealedDoor;
        }

        public bool GetVictory()
        {
            return won;
        }

        public bool GetSwitched()
        {
            return switched;
        }

    }
}
