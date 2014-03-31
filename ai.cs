            int step = 0;
            bool col = true;
            //Timer timer = new Timer(100);
            //ConsoleKeyInfo keyinfo;
            do
            {
                //keyinfo = Console.ReadKey(true);
                //Console.CursorVisible = false;
                int plxn = buz.Plx;
                int plyn = buz.Ply;

                if (col)
                {
                    step = rnd.Next(4);
                }
                else
                {
                    if (rnd.Next(10) == 2)
                    {
                        step = rnd.Next(4);
                    }
                }

                if (map.mapData[(buz.Plx - 1), buz.Ply].Visual == Visuals.PRICE)
                {
                    step = 2;
                }
                if (map.mapData[(buz.Plx + 1), buz.Ply].Visual == Visuals.PRICE)
                {
                    step = 3;

                }
                if (map.mapData[buz.Plx, (buz.Ply - 1)].Visual == Visuals.PRICE)
                {
                    step = 0;

                }
                if (map.mapData[buz.Plx, (buz.Ply + 1)].Visual == Visuals.PRICE)
                {
                    step = 1;

                }



                Console.Write("\b{0}", step);
                switch (step)
                {
                        
                    case 0:
                        plyn = buz.Ply - 1;
                        break;
                    case 1:
                        plyn = buz.Ply + 1;
                        break;
                    case 2:
                        plxn = buz.Plx - 1;
                        break;
                    case 3:
                        plxn = buz.Plx + 1;
                        break;

                    default:
                        break;
                }


                if (!map.mapData[plxn, plyn].Collision)
                {
                    disp.ShowPlayer(buz, plxn, plyn);
                    buz.Plx = plxn;
                    buz.Ply = plyn;
                    if (map.mapData[plxn, plyn].Visual == Visuals.PRICE)
                    {
                        buz.Score++;
                        Console.SetCursorPosition(0, 22);
                        Console.WriteLine("PRICE!: {0}", buz.Score);
                        map.mapData[plxn, plyn].Visual = Visuals.SPACE;
                        
                    }
                    col = false;
                }
                else
                {
                col = true;

                }
                System.Threading.Thread.Sleep(25);
            }
            while (true);
