﻿using Flare_Sharp.ClientBase.Categories;
using Flare_Sharp.ClientBase.Keybinds;
using Flare_Sharp.ClientBase.Modules.Modules;
using Flare_Sharp.Memory.FlameSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Flare_Sharp.ClientBase.Modules
{
    public class ModuleHandler
    {
        public static ModuleHandler registry;
        public ModuleHandler()
        {
            registry = this;
            
            Console.WriteLine("Module ticking statistics starting...");
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Elapsed += (object send, ElapsedEventArgs arg) => {
                tps = currentTick;
                currentTick = 0;
                Console.WriteLine("Module ticks per second: " + tps);
            };
            timer.Interval = 1000;
            timer.Start();
            
            Console.WriteLine("Starting module register...");
            /* Register modules here */
            new Killaura();
            new YesFall();
            new SuperKnockBack();
            new NegativeKnockBack();
            new NegativeSuperKnockback();
            new AirWater();
            new NoCrouch();
            new NoJump();
            new Rubberband();
            new StupidScaffold();
            new StupidScaffold2();
            new TFreaky();
            new TPAura();
            new Twerk1();
            new Twerk2();
            new Twerk3();
            new Twerk4();
            new XBoost();
            new ZBoost();
            new Aimbot();
            new Hitbox();
            new Triggerbot();
            new BoostHit();
            new Criticals();
            new Misplace();
            new Reach();
            new RapidClick();
            new AirJump();
            new Glide();
            new HighJump();
            new AutoSprint();
            new PlayerSpeed();
            new Jesus();
            new NoWater();
            new BHOP();
            new NoSlowDown();
            new NoKnockBack();
            new NoWeb();
            new FastLadder();
            new AirAcceleration();
            new Velocity();
            new Jetpack();
            new YBoost();
            new Coordinates();
            new InventoryMove();
            new AutoWalk();
            new Flight();
            new BounceFly();
            new JitterFlight();
            new TickedGlide();
            new Scaffold();
            new Tower();
            new Gamemode();
            new NoFall();
            new Phase();
            new NoSwing();
            new ClickTP();
            new Instabreak();
            new AutoRespawn();
            new Recall();
            new FOV();
            new AutoCrouch();
            new LagSpoof();
            new NoPacket(); //42
            new Freecam();
            new NoShadow();
            //new ServerCrasher(); <- Removed. 1. didnt work 2. UC doesnt allow it (luv u guys @ UC <3)
            new ClickUI();
            new TabGUI();
            new ModuleList();
            new TPFlight();
            new ListTest();
            //new AntiSentinel();
            new CpuLimiter();
            new RainbowUI();
            new CoordinatesDisplay();
            new CubeCraftFly();
            Console.WriteLine("Modules registered!");
            startModuleThread();
        }

        uint tps = 0;
        uint currentTick = 0;
        public void tickModuleThread()
        {
            foreach (Category category in CategoryHandler.registry.categories)
            {
                foreach (Module module in category.modules)
                {
                    try
                    {
                        module.onLoop().ConfigureAwait(false);
                        currentTick++;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine(ex.StackTrace);
                    }
                }
            }
        }
        public void startModuleThread()
        {
            Console.WriteLine("Starting module thread..");
            Program.mainLoop += (object sen, EventArgs e) =>
            {
                tickModuleThread();
            };
            Console.WriteLine("Module thread started!");
        }

        private void RunAsync(Task task)
        {
            task.ContinueWith(t =>
            {
                Console.WriteLine("Unexpected Error, {0}", t.Exception);

            }, TaskContinuationOptions.OnlyOnFaulted);
        }
    }
}
