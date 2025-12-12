using Microsoft.EntityFrameworkCore;
using SkyMoney_Admin_System.Models;

namespace SkyMoney_Admin_System.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new AppDbContext(
            serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>());
        if (context.UserAccounts.Any())
        {
            return;
        }

        var users = new List<UserAccount>
{
    new UserAccount
    {
        FirstName = "Michael",
        LastName = "Jordan",
        EmailAddress = "mj23@skymoney.app",
        IncomeType = IncomeType.Regular,
        NextScheduledPayDate = DateTime.Today.AddDays(7),
        PayFrequency = PayFrequencyType.BiWeekly,
        CreatedAt = DateTime.UtcNow.AddDays(-200)
    },
    new UserAccount
    {
        FirstName = "LeBron",
        LastName = "James",
        EmailAddress = "kingjames@skymoney.app",
        IncomeType = IncomeType.Regular,
        NextScheduledPayDate = DateTime.Today.AddDays(5),
        PayFrequency = PayFrequencyType.BiWeekly,
        CreatedAt = DateTime.UtcNow.AddDays(-60)

    },
    new UserAccount
    {
        FirstName = "Kobe",
        LastName = "Bryant",
        EmailAddress = "mamba@skymoney.app",
        IncomeType = IncomeType.Regular,
        NextScheduledPayDate = DateTime.Today.AddDays(10),
        PayFrequency = PayFrequencyType.BiWeekly,
        CreatedAt = DateTime.UtcNow.AddDays(-120)
    },
    new UserAccount
    {
        FirstName = "Magic",
        LastName = "Johnson",
        EmailAddress = "magic@skymoney.app",
        IncomeType = IncomeType.Irregular,
        CreatedAt = DateTime.UtcNow.AddDays(-220)
    },
    new UserAccount
    {
        FirstName = "Larry",
        LastName = "Bird",
        EmailAddress = "larry.legend@skymoney.app",
        IncomeType = IncomeType.Regular,
        NextScheduledPayDate = DateTime.Today.AddDays(3),
        PayFrequency = PayFrequencyType.Monthly,
        CreatedAt = DateTime.UtcNow.AddDays(-230)
    },
    new UserAccount
    {
        FirstName = "Kareem",
        LastName = "Abdul-Jabbar",
        EmailAddress = "captain@skymoney.app",
        IncomeType = IncomeType.Regular,
        NextScheduledPayDate = DateTime.Today.AddDays(12),
        PayFrequency = PayFrequencyType.Monthly,
        CreatedAt = DateTime.UtcNow.AddDays(-260)
    },
    new UserAccount
    {
        FirstName = "Shaquille",
        LastName = "O'Neal",
        EmailAddress = "shaq@skymoney.app",
        IncomeType = IncomeType.Irregular,
        CreatedAt = DateTime.UtcNow.AddDays(-140)
    },
    new UserAccount
    {
        FirstName = "Tim",
        LastName = "Duncan",
        EmailAddress = "thebigfundamental@skymoney.app",
        IncomeType = IncomeType.Regular,
        NextScheduledPayDate = DateTime.Today.AddDays(9),
        PayFrequency = PayFrequencyType.Monthly,
        CreatedAt = DateTime.UtcNow.AddDays(-60)
    },
    new UserAccount
    {
        FirstName = "Hakeem",
        LastName = "Olajuwon",
        EmailAddress = "thedream@skymoney.app",
        IncomeType = IncomeType.Regular,
        NextScheduledPayDate = DateTime.Today.AddDays(6),
        PayFrequency = PayFrequencyType.Monthly,
        CreatedAt = DateTime.UtcNow.AddDays(-160)
    },
    new UserAccount
    {
        FirstName = "Dirk",
        LastName = "Nowitzki",
        EmailAddress = "dirk41@skymoney.app",
        IncomeType = IncomeType.Regular,
        NextScheduledPayDate = DateTime.Today.AddDays(8),
        PayFrequency = PayFrequencyType.Weekly,        CreatedAt = DateTime.UtcNow.AddDays(-100)
    },
    new UserAccount
    {
        FirstName = "Stephen",
        LastName = "Curry",
        EmailAddress = "chef@skymoney.app",
        IncomeType = IncomeType.Regular,
        NextScheduledPayDate = DateTime.Today.AddDays(4),
        PayFrequency = PayFrequencyType.BiWeekly,        CreatedAt = DateTime.UtcNow.AddDays(-10)
    },
    new UserAccount
    {
        FirstName = "Kevin",
        LastName = "Durant",
        EmailAddress = "slimreaper@skymoney.app",
        IncomeType = IncomeType.Irregular,
        CreatedAt = DateTime.UtcNow.AddDays(-40)
    },
    new UserAccount
    {
        FirstName = "Allen",
        LastName = "Iverson",
        EmailAddress = "we.talkin.bout.practice@skymoney.app",
        IncomeType = IncomeType.Irregular,
        CreatedAt = DateTime.UtcNow.AddDays(-60)
    },
    new UserAccount
    {
        FirstName = "Bill",
        LastName = "Russell",
        EmailAddress = "rings11@skymoney.app",
        IncomeType = IncomeType.Regular,
        NextScheduledPayDate = DateTime.Today.AddDays(15),
        PayFrequency = PayFrequencyType.Weekly,        CreatedAt = DateTime.UtcNow.AddDays(-300)
    },
    new UserAccount
    {
        FirstName = "Wilt",
        LastName = "Chamberlain",
        EmailAddress = "100points@skymoney.app",
        IncomeType = IncomeType.Regular,
        NextScheduledPayDate = DateTime.Today.AddDays(2),
        PayFrequency = PayFrequencyType.BiWeekly,        CreatedAt = DateTime.UtcNow.AddDays(-310)
    },
     new UserAccount
    {
        FirstName = "Russell",
        LastName = "Westbrook",
        EmailAddress = "whynot@skymoney.app",
        IncomeType = IncomeType.Regular,
        NextScheduledPayDate = DateTime.Today.AddDays(3),
        PayFrequency = PayFrequencyType.Weekly,
        CreatedAt = DateTime.UtcNow.AddDays(-45)
    },

    // George Mikan
    new UserAccount
    {
        FirstName = "George",
        LastName = "Mikan",
        EmailAddress = "mikan.rule@skymoney.app",
        IncomeType = IncomeType.Regular,
        NextScheduledPayDate = DateTime.Today.AddDays(14),
        PayFrequency = PayFrequencyType.Monthly,
        CreatedAt = DateTime.UtcNow.AddDays(-400)
    },

    // James Worthy
    new UserAccount
    {
        FirstName = "James",
        LastName = "Worthy",
        EmailAddress = "biggamejames@skymoney.app",
        IncomeType = IncomeType.Regular,
        NextScheduledPayDate = DateTime.Today.AddDays(6),
        PayFrequency = PayFrequencyType.BiWeekly,
        CreatedAt = DateTime.UtcNow.AddDays(-210)
    },

    // John Stockton
    new UserAccount
    {
        FirstName = "John",
        LastName = "Stockton",
        EmailAddress = "assistking@skymoney.app",
        IncomeType = IncomeType.Regular,
        NextScheduledPayDate = DateTime.Today.AddDays(4),
        PayFrequency = PayFrequencyType.BiWeekly,
        CreatedAt = DateTime.UtcNow.AddDays(-260)
    },

    // Shai Gilgeous-Alexander
    new UserAccount
    {
        FirstName = "Shai",
        LastName = "Gilgeous-Alexander",
        EmailAddress = "sga@skymoney.app",
        IncomeType = IncomeType.Regular,
        NextScheduledPayDate = DateTime.Today.AddDays(5),
        PayFrequency = PayFrequencyType.BiWeekly,
        CreatedAt = DateTime.UtcNow.AddDays(-30)
    },

    // Reggie Miller
    new UserAccount
    {
        FirstName = "Reggie",
        LastName = "Miller",
        EmailAddress = "knickskiller@skymoney.app",
        IncomeType = IncomeType.Regular,
        NextScheduledPayDate = DateTime.Today.AddDays(9),
        PayFrequency = PayFrequencyType.Monthly,
        CreatedAt = DateTime.UtcNow.AddDays(-280)
    },

    // James Harden
    new UserAccount
    {
        FirstName = "James",
        LastName = "Harden",
        EmailAddress = "stepback@skymoney.app",
        IncomeType = IncomeType.Irregular,
        CreatedAt = DateTime.UtcNow.AddDays(-90)
    },

    // BONUS: Kawhi Leonard
    new UserAccount
    {
        FirstName = "Kawhi",
        LastName = "Leonard",
        EmailAddress = "boardman@getspaid.app",
        IncomeType = IncomeType.Regular,
        NextScheduledPayDate = DateTime.Today.AddDays(11),
        PayFrequency = PayFrequencyType.Monthly,
        CreatedAt = DateTime.UtcNow.AddDays(-150)
    },

    new UserAccount
    {
        FirstName = "Giannis",
        LastName = "Antetokounmpo",
        EmailAddress = "greekfreak@skymoney.app",
        IncomeType = IncomeType.Regular,
        NextScheduledPayDate = DateTime.Today.AddDays(7),
        PayFrequency = PayFrequencyType.BiWeekly,
        CreatedAt = DateTime.UtcNow.AddDays(-70)
    }
};

        context.UserAccounts.AddRange(users);
        context.SaveChanges();

        var mj = users.Single(u => u.FirstName == "Michael" && u.LastName == "Jordan");
        var lebron = users.Single(u => u.FirstName == "LeBron" && u.LastName == "James");
        var kobe = users.Single(u => u.FirstName == "Kobe" && u.LastName == "Bryant");
        var magic = users.Single(u => u.FirstName == "Magic" && u.LastName == "Johnson");
        var bird = users.Single(u => u.FirstName == "Larry" && u.LastName == "Bird");
        var kareem = users.Single(u => u.FirstName == "Kareem" && u.LastName == "Abdul-Jabbar");
        var shaq = users.Single(u => u.FirstName == "Shaquille" && u.LastName == "O'Neal");
        var duncan = users.Single(u => u.FirstName == "Tim" && u.LastName == "Duncan");
        var hakeem = users.Single(u => u.FirstName == "Hakeem" && u.LastName == "Olajuwon");
        var dirk = users.Single(u => u.FirstName == "Dirk" && u.LastName == "Nowitzki");
        var curry = users.Single(u => u.FirstName == "Stephen" && u.LastName == "Curry");
        var kd = users.Single(u => u.FirstName == "Kevin" && u.LastName == "Durant");
        var ai = users.Single(u => u.FirstName == "Allen" && u.LastName == "Iverson");
        var russ = users.Single(u => u.FirstName == "Bill" && u.LastName == "Russell");
        var wilt = users.Single(u => u.FirstName == "Wilt" && u.LastName == "Chamberlain");
        var westbrook = users.Single(u => u.FirstName == "Russell" && u.LastName == "Westbrook");
        var mikan = users.Single(u => u.FirstName == "George" && u.LastName == "Mikan");
        var worthy = users.Single(u => u.FirstName == "James" && u.LastName == "Worthy");
        var stockton = users.Single(u => u.FirstName == "John" && u.LastName == "Stockton");
        var shai = users.Single(u => u.FirstName == "Shai" && u.LastName == "Gilgeous-Alexander");
        var reggie = users.Single(u => u.FirstName == "Reggie" && u.LastName == "Miller");
        var harden = users.Single(u => u.FirstName == "James" && u.LastName == "Harden");
        var kawhi = users.Single(u => u.FirstName == "Kawhi" && u.LastName == "Leonard");
        var giannis = users.Single(u => u.FirstName == "Giannis" && u.LastName == "Antetokounmpo");
        var budgets = new List<BudgetPlan>
        {
            new BudgetPlan
            {
                UserAccountId = mj.UserAccountId,
                PlanName = "Air Jordan GOAT Budget",
                TotalBudget = 23000m,
                FundedExpenses = 12000m  // Available: 11000
            },
            new BudgetPlan
            {
                UserAccountId = lebron.UserAccountId,
                PlanName = "King James Lifetime Budget",
                TotalBudget = 27000m,
                FundedExpenses = 15000m  // Available: 12000
            },
            new BudgetPlan
            {
                UserAccountId = kobe.UserAccountId,
                PlanName = "Mamba Mentality Budget",
                TotalBudget = 24000m,
                FundedExpenses = 13000m
            },
            new BudgetPlan
            {
                UserAccountId = magic.UserAccountId,
                PlanName = "Showtime Lakers Budget",
                TotalBudget = 18000m,
                FundedExpenses = 9000m
            },
            new BudgetPlan
            {
                UserAccountId = bird.UserAccountId,
                PlanName = "Celtics Legend Budget",
                TotalBudget = 19000m,
                FundedExpenses = 10000m
            },
            new BudgetPlan
            {
                UserAccountId = kareem.UserAccountId,
                PlanName = "Skyhook Retirement Budget",
                TotalBudget = 21000m,
                FundedExpenses = 11000m
            },
            new BudgetPlan
            {
                UserAccountId = shaq.UserAccountId,
               PlanName = "Diesel Big Man Budget",
                TotalBudget = 22000m,
                FundedExpenses = 14000m
            },
            new BudgetPlan
            {
                UserAccountId = duncan.UserAccountId,
                PlanName = "Big Fundamental Budget",
                TotalBudget = 16000m,
                FundedExpenses = 8000m
            },
            new BudgetPlan
            {
                UserAccountId = hakeem.UserAccountId,
                PlanName = "Dream Shake Budget",
                TotalBudget = 17000m,
                FundedExpenses = 9000m
            },
            new BudgetPlan
            {
                UserAccountId = dirk.UserAccountId,
                PlanName = "One-Legged Fade Budget",
                TotalBudget = 15000m,
                FundedExpenses = 7000m
            },
            new BudgetPlan
            {
                UserAccountId = curry.UserAccountId,
                PlanName = "Logo Three Budget",
                TotalBudget = 20000m,
                FundedExpenses = 9000m
            },
            new BudgetPlan
            {
                UserAccountId = kd.UserAccountId,
                PlanName = "Slim Reaper Budget",
                TotalBudget = 21000m,
                FundedExpenses = 10000m
            },
            new BudgetPlan
            {
                UserAccountId = ai.UserAccountId,
                PlanName = "We Talkin' Budget Budget",
                TotalBudget = 14000m,
                FundedExpenses = 6000m
            },
            new BudgetPlan
            {
                UserAccountId = russ.UserAccountId,
                PlanName = "11 Rings Legacy Budget",
                TotalBudget = 25000m,
                FundedExpenses = 18000m
            },
            new BudgetPlan
            {
                UserAccountId = wilt.UserAccountId,
                PlanName = "100-Point Night Budget",
                TotalBudget = 26000m,
                FundedExpenses = 16000m
            },
 new BudgetPlan
    {
        UserAccountId = westbrook.UserAccountId,
        PlanName = "Why Not? Triple-Double Budget",
        TotalBudget = 19000m,
        FundedExpenses = 11000m
    },

    // George Mikan
    new BudgetPlan
    {
        UserAccountId = mikan.UserAccountId,
        PlanName = "Mikan Rule Pioneer Budget",
        TotalBudget = 17000m,
        FundedExpenses = 9000m
    },

    // James Worthy
    new BudgetPlan
    {
        UserAccountId = worthy.UserAccountId,
        PlanName = "Big Game James Budget",
        TotalBudget = 18500m,
        FundedExpenses = 10000m
    },

    // John Stockton
    new BudgetPlan
    {
        UserAccountId = stockton.UserAccountId,
        PlanName = "Assist King Savings Plan",
        TotalBudget = 16000m,
        FundedExpenses = 8000m
    },

    // Shai Gilgeous-Alexander
    new BudgetPlan
    {
        UserAccountId = shai.UserAccountId,
        PlanName = "SGA All-NBA Budget",
        TotalBudget = 20000m,
        FundedExpenses = 11000m
    },

    // Reggie Miller
    new BudgetPlan
    {
        UserAccountId = reggie.UserAccountId,
        PlanName = "Knicks Killer Budget",
        TotalBudget = 17500m,
        FundedExpenses = 9500m
    },

    // James Harden
    new BudgetPlan
    {
        UserAccountId = harden.UserAccountId,
        PlanName = "Stepback & Beard Care Budget",
        TotalBudget = 21000m,
        FundedExpenses = 12000m
    },

    // Kawhi Leonard
    new BudgetPlan
    {
        UserAccountId = kawhi.UserAccountId,
        PlanName = "Board Man Gets Paid Budget",
        TotalBudget = 19500m,
        FundedExpenses = 10500m
    },

    // Giannis Antetokounmpo
    new BudgetPlan
    {
        UserAccountId = giannis.UserAccountId,
        PlanName = "Greek Freak Two-Way Budget",
        TotalBudget = 22000m,
        FundedExpenses = 13000m
    }

        };

        context.BudgetPlans.AddRange(budgets);
        context.SaveChanges();

        // Quick lookup
        BudgetPlan BudgetFor(UserAccount user) =>
            budgets.Single(b => b.UserAccountId == user.UserAccountId);

        var fixedExpenses = new List<FixedExpense>
        {
            // Michael Jordan
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(mj).BudgetPlanId,
                Name = "Championship Ring Insurance",
                Amount = 3000m,
                FundedAmount = 2000m,
                DueDate = DateTime.Today.AddDays(5),
                IsFinanced = false
            },
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(mj).BudgetPlanId,
                Name = "Air Jordan Sneaker Vault Security",
                Amount = 2500m,
                FundedAmount = 2500m,
                DueDate = DateTime.Today.AddDays(12),
                IsFinanced = false
            },

            // LeBron James
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(lebron).BudgetPlanId,
                Name = "Home Gym LeCryotherapy Bill",
                Amount = 2800m,
                FundedAmount = 1800m,
                DueDate = DateTime.Today.AddDays(4),
                IsFinanced = false
            },
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(lebron).BudgetPlanId,
                Name = "Taco Tuesday Catering Subscription",
                Amount = 1200m,
                FundedAmount = 1200m,
                DueDate = DateTime.Today.AddDays(20),
                IsFinanced = false
            },

            // Kobe Bryant
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(kobe).BudgetPlanId,
                Name = "Mamba Academy Facility Lease",
                Amount = 3200m,
                FundedAmount = 1500m,
                DueDate = DateTime.Today.AddDays(6),
                IsFinanced = false
            },
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(kobe).BudgetPlanId,
                Name = "Film Study Streaming Services",
                Amount = 600m,
                FundedAmount = 600m,
                DueDate = DateTime.Today.AddDays(18),
                IsFinanced = false
            },

            // Magic
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(magic).BudgetPlanId,
                Name = "Showtime Courtside Seats Subscription",
                Amount = 2000m,
                FundedAmount = 1000m,
                DueDate = DateTime.Today.AddDays(7),
                IsFinanced = true
            },
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(magic).BudgetPlanId,
                Name = "Business Suit Dry Cleaning Plan",
                Amount = 400m,
                FundedAmount = 200m,
                DueDate = DateTime.Today.AddDays(3),
                IsFinanced = false
            },

            // Larry Bird
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(bird).BudgetPlanId,
                Name = "Indiana Farm Property Tax",
                Amount = 2500m,
                FundedAmount = 2000m,
                DueDate = DateTime.Today.AddDays(9),
                IsFinanced = false
            },
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(bird).BudgetPlanId,
                Name = "Three-Point Contest Entry Fee",
                Amount = 300m,
                FundedAmount = 300m,
                DueDate = DateTime.Today.AddDays(30),
                IsFinanced = false
            },

            // Kareem
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(kareem).BudgetPlanId,
                Name = "Skyhook Yoga Membership",
                Amount = 500m,
                FundedAmount = 400m,
                DueDate = DateTime.Today.AddDays(10),
                IsFinanced = false
            },
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(kareem).BudgetPlanId,
                Name = "Book Club Hosting Costs",
                Amount = 350m,
                FundedAmount = 350m,
                DueDate = DateTime.Today.AddDays(21),
                IsFinanced = false
            },

            // Shaq
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(shaq).BudgetPlanId,
                Name = "Backboard Replacement Insurance",
                Amount = 2700m,
                FundedAmount = 1500m,
                DueDate = DateTime.Today.AddDays(2),
                IsFinanced = false
            },
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(shaq).BudgetPlanId,
                Name = "Shaq-Fu Streaming Royalties Lawyer",
                Amount = 900m,
                FundedAmount = 600m,
                DueDate = DateTime.Today.AddDays(15),
                IsFinanced = true
            },

            // Tim Duncan
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(duncan).BudgetPlanId,
                Name = "Fundamental Bank Shot Clinic Rent",
                Amount = 1800m,
                FundedAmount = 1300m,
                DueDate = DateTime.Today.AddDays(8),
                IsFinanced = false
            },
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(duncan).BudgetPlanId,
                Name = "San Antonio Riverwalk Condo HOA",
                Amount = 900m,
                FundedAmount = 900m,
                DueDate = DateTime.Today.AddDays(25),
                IsFinanced = false
            },

            // Hakeem
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(hakeem).BudgetPlanId,
                Name = "Dream Shake Footwork Studio Lease",
                Amount = 2000m,
                FundedAmount = 1300m,
                DueDate = DateTime.Today.AddDays(11),
                IsFinanced = false
            },
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(hakeem).BudgetPlanId,
                Name = "Houston Skyline Apartment Rent",
                Amount = 2200m,
                FundedAmount = 2200m,
                DueDate = DateTime.Today.AddDays(5),
                IsFinanced = false
            },

            // Dirk
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(dirk).BudgetPlanId,
                Name = "Dallas One-Legged Fade Studio",
                Amount = 1600m,
                FundedAmount = 800m,
                DueDate = DateTime.Today.AddDays(6),
                IsFinanced = false
            },
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(dirk).BudgetPlanId,
                Name = "German Bakery Subscription",
                Amount = 400m,
                FundedAmount = 400m,
                DueDate = DateTime.Today.AddDays(14),
                IsFinanced = false
            },

            // Steph Curry
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(curry).BudgetPlanId,
                Name = "Logo Three Distance Tracking App",
                Amount = 700m,
                FundedAmount = 500m,
                DueDate = DateTime.Today.AddDays(9),
                IsFinanced = false
            },
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(curry).BudgetPlanId,
                Name = "Family Postgame Dinner Reservation Plan",
                Amount = 900m,
                FundedAmount = 900m,
                DueDate = DateTime.Today.AddDays(18),
                IsFinanced = false
            },

            // KD
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(kd).BudgetPlanId,
                Name = "Burner Account Phone Plan",
                Amount = 300m,
                FundedAmount = 150m,
                DueDate = DateTime.Today.AddDays(4),
                IsFinanced = false
            },
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(kd).BudgetPlanId,
                Name = "Slim Reaper Training Facility",
                Amount = 1900m,
                FundedAmount = 1000m,
                DueDate = DateTime.Today.AddDays(13),
                IsFinanced = true
            },

            // Allen Iverson
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(ai).BudgetPlanId,
                Name = "Braids Maintenance Subscription",
                Amount = 600m,
                FundedAmount = 400m,
                DueDate = DateTime.Today.AddDays(3),
                IsFinanced = false
            },
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(ai).BudgetPlanId,
                Name = "Practice Reminder App (Unused)",
                Amount = 100m,
                FundedAmount = 0m,
                DueDate = DateTime.Today.AddDays(1),
                IsFinanced = false
            },

            // Bill Russell
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(russ).BudgetPlanId,
                Name = "Championship Ring Polishing (x11)",
                Amount = 3300m,
                FundedAmount = 2000m,
                DueDate = DateTime.Today.AddDays(7),
                IsFinanced = false
            },
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(russ).BudgetPlanId,
                Name = "Leadership Seminar Venue",
                Amount = 1200m,
                FundedAmount = 1200m,
                DueDate = DateTime.Today.AddDays(20),
                IsFinanced = false
            },

            // Wilt
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(wilt).BudgetPlanId,
                Name = "Scoreboard Upgrade Donation",
                Amount = 2600m,
                FundedAmount = 1600m,
                DueDate = DateTime.Today.AddDays(10),
                IsFinanced = false
            },
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(wilt).BudgetPlanId,
                Name = "Historic Stat Archive Hosting",
                Amount = 800m,
                FundedAmount = 800m,
                DueDate = DateTime.Today.AddDays(16),
                IsFinanced = false
            },
            // Russell Westbrook
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(westbrook).BudgetPlanId,
                Name = "Triple-Double Recovery Ice Baths",
                Amount = 1400m,
                FundedAmount = 900m,
                DueDate = DateTime.Today.AddDays(5),
                IsFinanced = false
            },
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(westbrook).BudgetPlanId,
                Name = "Why Not? Fashion Line Lease",
                Amount = 1200m,
                FundedAmount = 600m,
                DueDate = DateTime.Today.AddDays(18),
                IsFinanced = true
            },

            // George Mikan
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(mikan).BudgetPlanId,
                Name = "Old-School Arena Preservation Fund",
                Amount = 900m,
                FundedAmount = 700m,
                DueDate = DateTime.Today.AddDays(9),
                IsFinanced = false
            },
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(mikan).BudgetPlanId,
                Name = "Mikan Drill Youth Camp Rental",
                Amount = 750m,
                FundedAmount = 500m,
                DueDate = DateTime.Today.AddDays(21),
                IsFinanced = false
            },

            // James Worthy
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(worthy).BudgetPlanId,
                Name = "Big Game Playoff Travel Package",
                Amount = 1800m,
                FundedAmount = 1200m,
                DueDate = DateTime.Today.AddDays(7),
                IsFinanced = false
            },
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(worthy).BudgetPlanId,
                Name = "Showtime Suit Tailoring",
                Amount = 600m,
                FundedAmount = 600m,
                DueDate = DateTime.Today.AddDays(19),
                IsFinanced = false
            },

            // John Stockton
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(stockton).BudgetPlanId,
                Name = "Assist Tracker Analytics Subscription",
                Amount = 500m,
                FundedAmount = 400m,
                DueDate = DateTime.Today.AddDays(4),
                IsFinanced = false
            },
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(stockton).BudgetPlanId,
                Name = "Vintage Short Shorts Restock",
                Amount = 350m,
                FundedAmount = 200m,
                DueDate = DateTime.Today.AddDays(16),
                IsFinanced = true
            },

            // Shai Gilgeous-Alexander
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(shai).BudgetPlanId,
                Name = "Tunnel Fit Stylist Retainer",
                Amount = 2000m,
                FundedAmount = 1200m,
                DueDate = DateTime.Today.AddDays(6),
                IsFinanced = false
            },
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(shai).BudgetPlanId,
                Name = "All-NBA Award Shelf Installation",
                Amount = 950m,
                FundedAmount = 500m,
                DueDate = DateTime.Today.AddDays(17),
                IsFinanced = true
            },

            // Reggie Miller
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(reggie).BudgetPlanId,
                Name = "MSG Noise-Canceling Earplugs Subscription",
                Amount = 400m,
                FundedAmount = 400m,
                DueDate = DateTime.Today.AddDays(3),
                IsFinanced = false
            },
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(reggie).BudgetPlanId,
                Name = "Three-Point Line Documentary Production",
                Amount = 1600m,
                FundedAmount = 800m,
                DueDate = DateTime.Today.AddDays(20),
                IsFinanced = true
            },

            // James Harden
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(harden).BudgetPlanId,
                Name = "Beard Care Product Sponsorship Buy-In",
                Amount = 1300m,
                FundedAmount = 700m,
                DueDate = DateTime.Today.AddDays(8),
                IsFinanced = false
            },
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(harden).BudgetPlanId,
                Name = "Stepback Shooting Lab Lease",
                Amount = 1700m,
                FundedAmount = 900m,
                DueDate = DateTime.Today.AddDays(22),
                IsFinanced = true
            },

            // Kawhi Leonard
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(kawhi).BudgetPlanId,
                Name = "Load Management Wellness Program",
                Amount = 1500m,
                FundedAmount = 1000m,
                DueDate = DateTime.Today.AddDays(11),
                IsFinanced = false
            },
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(kawhi).BudgetPlanId,
                Name = "New Balance Endorsement Photoshoots",
                Amount = 800m,
                FundedAmount = 400m,
                DueDate = DateTime.Today.AddDays(25),
                IsFinanced = true
            },

            // Giannis Antetokounmpo
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(giannis).BudgetPlanId,
                Name = "Family Trip to Greece",
                Amount = 2200m,
                FundedAmount = 1400m,
                DueDate = DateTime.Today.AddDays(9),
                IsFinanced = false
            },
            new FixedExpense
            {
                BudgetPlanId = BudgetFor(giannis).BudgetPlanId,
                Name = "Free Throw Routine Sports Psychologist",
                Amount = 900m,
                FundedAmount = 450m,
                DueDate = DateTime.Today.AddDays(21),
                IsFinanced = true
            }

        };

        context.FixedExpenses.AddRange(fixedExpenses);
        context.SaveChanges();

        // -------------------------------
        // 4. VARIABLE EXPENSES
        // -------------------------------

        var variableExpenses = new List<VariableExpense>
        {
            // MJ
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(mj).BudgetPlanId,
                CategoryName = "Shoe Collection",
                PercentOfAvailableBudget = 35m,
                CategoryBalance = 3500m
            },
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(mj).BudgetPlanId,
                CategoryName = "Cigar Lounge Nights",
                PercentOfAvailableBudget = 20m,
                CategoryBalance = 2000m
            },

            // LeBron
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(lebron).BudgetPlanId,
                CategoryName = "Taco Tuesday Supplies",
                PercentOfAvailableBudget = 25m,
                CategoryBalance = 2500m
            },
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(lebron).BudgetPlanId,
                CategoryName = "Kids AAU Travel",
                PercentOfAvailableBudget = 30m,
                CategoryBalance = 3000m
            },

            // Kobe
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(kobe).BudgetPlanId,
                CategoryName = "Late Night Gym Sessions",
                PercentOfAvailableBudget = 40m,
                CategoryBalance = 3200m
            },
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(kobe).BudgetPlanId,
                CategoryName = "Mamba Coffee & Film",
                PercentOfAvailableBudget = 25m,
                CategoryBalance = 2000m
            },

            // Magic
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(magic).BudgetPlanId,
                CategoryName = "Business Lunches",
                PercentOfAvailableBudget = 30m,
                CategoryBalance = 2100m
            },
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(magic).BudgetPlanId,
                CategoryName = "Showtime Wardrobe",
                PercentOfAvailableBudget = 20m,
                CategoryBalance = 1400m
            },

            // Larry Bird
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(bird).BudgetPlanId,
                CategoryName = "Trash Talk Coffee",
                PercentOfAvailableBudget = 15m,
                CategoryBalance = 1350m
            },
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(bird).BudgetPlanId,
                CategoryName = "Practice Gym Time",
                PercentOfAvailableBudget = 35m,
                CategoryBalance = 3150m
            },

            // Kareem
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(kareem).BudgetPlanId,
                CategoryName = "Book Store Runs",
                PercentOfAvailableBudget = 30m,
                CategoryBalance = 3000m
            },
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(kareem).BudgetPlanId,
                CategoryName = "Skyhook Training Camps",
                PercentOfAvailableBudget = 25m,
                CategoryBalance = 2500m
            },

            // Shaq
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(shaq).BudgetPlanId,
                CategoryName = "Shaq's Big Snacks",
                PercentOfAvailableBudget = 40m,
                CategoryBalance = 3200m
            },
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(shaq).BudgetPlanId,
                CategoryName = "DJ Diesel Gigs Travel",
                PercentOfAvailableBudget = 25m,
                CategoryBalance = 2000m
            },

            // Tim Duncan
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(duncan).BudgetPlanId,
                CategoryName = "Fundamental Family Time",
                PercentOfAvailableBudget = 25m,
                CategoryBalance = 2000m
            },
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(duncan).BudgetPlanId,
                CategoryName = "Quiet Fishing Trips",
                PercentOfAvailableBudget = 20m,
                CategoryBalance = 1600m
            },

            // Hakeem
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(hakeem).BudgetPlanId,
                CategoryName = "Dream Camp Scholarships",
                PercentOfAvailableBudget = 30m,
                CategoryBalance = 2400m
            },
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(hakeem).BudgetPlanId,
                CategoryName = "Footwork Clinics",
                PercentOfAvailableBudget = 25m,
                CategoryBalance = 2000m
            },

            // Dirk
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(dirk).BudgetPlanId,
                CategoryName = "German Food Nights",
                PercentOfAvailableBudget = 30m,
                CategoryBalance = 2400m
            },
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(dirk).BudgetPlanId,
                CategoryName = "Fadeaway Practice Time",
                PercentOfAvailableBudget = 25m,
                CategoryBalance = 2000m
            },

            // Steph Curry
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(curry).BudgetPlanId,
                CategoryName = "Three-Point Contest Wagers",
                PercentOfAvailableBudget = 35m,
                CategoryBalance = 3850m
            },
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(curry).BudgetPlanId,
                CategoryName = "Family Golf Rounds",
                PercentOfAvailableBudget = 20m,
                CategoryBalance = 2200m
            },

            // KD
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(kd).BudgetPlanId,
                CategoryName = "Art & Tech Investments",
                PercentOfAvailableBudget = 30m,
                CategoryBalance = 3300m
            },
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(kd).BudgetPlanId,
                CategoryName = "Twitter Therapy Sessions",
                PercentOfAvailableBudget = 15m,
                CategoryBalance = 1500m
            },

            // AI
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(ai).BudgetPlanId,
                CategoryName = "Tunnel Fits",
                PercentOfAvailableBudget = 35m,
                CategoryBalance = 2800m
            },
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(ai).BudgetPlanId,
                CategoryName = "Pick-Up Game Buy-Ins",
                PercentOfAvailableBudget = 20m,
                CategoryBalance = 1600m
            },

            // Bill Russell
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(russ).BudgetPlanId,
                CategoryName = "Community Programs",
                PercentOfAvailableBudget = 40m,
                CategoryBalance = 2800m
            },
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(russ).BudgetPlanId,
                CategoryName = "Championship Celebrations",
                PercentOfAvailableBudget = 20m,
                CategoryBalance = 1400m
            },

            // Wilt
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(wilt).BudgetPlanId,
                CategoryName = "Scoring History Memorabilia",
                PercentOfAvailableBudget = 30m,
                CategoryBalance = 3000m
            },
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(wilt).BudgetPlanId,
                CategoryName = "Travel to Tell the 100-Point Story",
                PercentOfAvailableBudget = 25m,
                CategoryBalance = 2500m
            },
            // Russell Westbrook
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(westbrook).BudgetPlanId,
                CategoryName = "Pre-Game Fashion Tunnel Fits",
                PercentOfAvailableBudget = 30m,
                CategoryBalance = 2700m
            },
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(westbrook).BudgetPlanId,
                CategoryName = "Charity Triple-Double Events",
                PercentOfAvailableBudget = 20m,
                CategoryBalance = 1800m
            },

            // George Mikan
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(mikan).BudgetPlanId,
                CategoryName = "Old-School Basketball Clinics",
                PercentOfAvailableBudget = 25m,
                CategoryBalance = 2000m
            },
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(mikan).BudgetPlanId,
                CategoryName = "Classic Era Memorabilia",
                PercentOfAvailableBudget = 15m,
                CategoryBalance = 1200m
            },

            // James Worthy
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(worthy).BudgetPlanId,
                CategoryName = "Big Game Broadcast Dinners",
                PercentOfAvailableBudget = 25m,
                CategoryBalance = 2100m
            },
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(worthy).BudgetPlanId,
                CategoryName = "Showtime Reunion Trips",
                PercentOfAvailableBudget = 20m,
                CategoryBalance = 1800m
            },

            // John Stockton
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(stockton).BudgetPlanId,
                CategoryName = "Pick-and-Roll Film Study Snacks",
                PercentOfAvailableBudget = 20m,
                CategoryBalance = 1500m
            },
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(stockton).BudgetPlanId,
                CategoryName = "Community Youth League Support",
                PercentOfAvailableBudget = 25m,
                CategoryBalance = 1900m
            },

            // Shai Gilgeous-Alexander
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(shai).BudgetPlanId,
                CategoryName = "Designer Tunnel Fits",
                PercentOfAvailableBudget = 35m,
                CategoryBalance = 3200m
            },
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(shai).BudgetPlanId,
                CategoryName = "Off-Season Skill Trainers",
                PercentOfAvailableBudget = 25m,
                CategoryBalance = 2300m
            },

            // Reggie Miller
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(reggie).BudgetPlanId,
                CategoryName = "Three-Point Shooting Camps",
                PercentOfAvailableBudget = 30m,
                CategoryBalance = 2600m
            },
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(reggie).BudgetPlanId,
                CategoryName = "Broadcast Prep Coffee Runs",
                PercentOfAvailableBudget = 15m,
                CategoryBalance = 1300m
            },

            // James Harden
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(harden).BudgetPlanId,
                CategoryName = "Nightlife & Club Appearances",
                PercentOfAvailableBudget = 35m,
                CategoryBalance = 3100m
            },
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(harden).BudgetPlanId,
                CategoryName = "Stepback Film Study Snacks",
                PercentOfAvailableBudget = 20m,
                CategoryBalance = 1800m
            },

            // Kawhi Leonard
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(kawhi).BudgetPlanId,
                CategoryName = "Load Management Getaways",
                PercentOfAvailableBudget = 25m,
                CategoryBalance = 2200m
            },
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(kawhi).BudgetPlanId,
                CategoryName = "Fun Guy BBQs",
                PercentOfAvailableBudget = 15m,
                CategoryBalance = 1300m
            },

            // Giannis Antetokounmpo
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(giannis).BudgetPlanId,
                CategoryName = "Family Dinners & Dad Jokes",
                PercentOfAvailableBudget = 25m,
                CategoryBalance = 2400m
            },
            new VariableExpense
            {
                BudgetPlanId = BudgetFor(giannis).BudgetPlanId,
                CategoryName = "Eurostep Travel Costs",
                PercentOfAvailableBudget = 20m,
                CategoryBalance = 2000m
            }

        };

        context.VariableExpenses.AddRange(variableExpenses);
        context.SaveChanges();

        // -------------------------------
        // 5. INCOME RECORDS
        // -------------------------------

        var incomes = new List<IncomeRecord>
        {
            new IncomeRecord
            {
                UserAccountId = mj.UserAccountId,
                Amount = 8000m,
                DateReceived = DateTime.Today.AddDays(-14),
                Notes = "Retro Air Jordan royalties"
            },
            new IncomeRecord
            {
                UserAccountId = mj.UserAccountId,
                Amount = 9000m,
                DateReceived = DateTime.Today.AddDays(-1),
                Notes = "G.O.A.T. documentary check"
            },

            new IncomeRecord
            {
                UserAccountId = lebron.UserAccountId,
                Amount = 7500m,
                DateReceived = DateTime.Today.AddDays(-7),
                Notes = "Space Jam 2 streaming residual"
            },
            new IncomeRecord
            {
                UserAccountId = lebron.UserAccountId,
                Amount = 8200m,
                DateReceived = DateTime.Today.AddDays(-1),
                Notes = "Clutch Sports advisory fee"
            },

            new IncomeRecord
            {
                UserAccountId = kobe.UserAccountId,
                Amount = 7000m,
                DateReceived = DateTime.Today.AddDays(-10),
                Notes = "Mamba Academy camp"
            },

            new IncomeRecord
            {
                UserAccountId = magic.UserAccountId,
                Amount = 6500m,
                DateReceived = DateTime.Today.AddDays(-20),
                Notes = "Business investments payout"
            },

            new IncomeRecord
            {
                UserAccountId = bird.UserAccountId,
                Amount = 5000m,
                DateReceived = DateTime.Today.AddDays(-12),
                Notes = "Front office consulting"
            },

            new IncomeRecord
            {
                UserAccountId = kareem.UserAccountId,
                Amount = 5200m,
                DateReceived = DateTime.Today.AddDays(-9),
                Notes = "Book royalties"
            },

            new IncomeRecord
            {
                UserAccountId = shaq.UserAccountId,
                Amount = 7800m,
                DateReceived = DateTime.Today.AddDays(-5),
                Notes = "Commercial + TNT show check"
            },

            new IncomeRecord
            {
                UserAccountId = duncan.UserAccountId,
                Amount = 4300m,
                DateReceived = DateTime.Today.AddDays(-15),
                Notes = "Spurs development role"
            },

            new IncomeRecord
            {
                UserAccountId = hakeem.UserAccountId,
                Amount = 4600m,
                DateReceived = DateTime.Today.AddDays(-8),
                Notes = "Post player training session"
            },

            new IncomeRecord
            {
                UserAccountId = dirk.UserAccountId,
                Amount = 4100m,
                DateReceived = DateTime.Today.AddDays(-11),
                Notes = "Mavs ambassador salary"
            },

            new IncomeRecord
            {
                UserAccountId = curry.UserAccountId,
                Amount = 9000m,
                DateReceived = DateTime.Today.AddDays(-3),
                Notes = "Under Armour deal"
            },

            new IncomeRecord
            {
                UserAccountId = kd.UserAccountId,
                Amount = 8500m,
                DateReceived = DateTime.Today.AddDays(-6),
                Notes = "Tech investment cash out"
            },

            new IncomeRecord
            {
                UserAccountId = ai.UserAccountId,
                Amount = 3800m,
                DateReceived = DateTime.Today.AddDays(-4),
                Notes = "Reebok lifetime deal payment"
            },

            new IncomeRecord
            {
                UserAccountId = russ.UserAccountId,
                Amount = 6000m,
                DateReceived = DateTime.Today.AddDays(-18),
                Notes = "Speaking engagement"
            },

            new IncomeRecord
            {
                UserAccountId = wilt.UserAccountId,
                Amount = 7200m,
                DateReceived = DateTime.Today.AddDays(-13),
                Notes = "Legacy documentary"
            },
              new IncomeRecord
    {
        UserAccountId = westbrook.UserAccountId,
        Amount = 6800m,
        DateReceived = DateTime.Today.AddDays(-7),
        Notes = "Why Not? brand signing bonus"
    },

    // George Mikan
    new IncomeRecord
    {
        UserAccountId = mikan.UserAccountId,
        Amount = 5200m,
        DateReceived = DateTime.Today.AddDays(-21),
        Notes = "Classic era rules symposium"
    },

    // James Worthy
    new IncomeRecord
    {
        UserAccountId = worthy.UserAccountId,
        Amount = 6100m,
        DateReceived = DateTime.Today.AddDays(-9),
        Notes = "Big Game James playoff commentary"
    },

    // John Stockton
    new IncomeRecord
    {
        UserAccountId = stockton.UserAccountId,
        Amount = 4800m,
        DateReceived = DateTime.Today.AddDays(-11),
        Notes = "Pick-and-roll coaching clinic"
    },

    // Shai Gilgeous-Alexander
    new IncomeRecord
    {
        UserAccountId = shai.UserAccountId,
        Amount = 9300m,
        DateReceived = DateTime.Today.AddDays(-3),
        Notes = "All-NBA bonus payout"
    },

    // Reggie Miller
    new IncomeRecord
    {
        UserAccountId = reggie.UserAccountId,
        Amount = 5500m,
        DateReceived = DateTime.Today.AddDays(-8),
        Notes = "National broadcast analyst check"
    },

    // James Harden
    new IncomeRecord
    {
        UserAccountId = harden.UserAccountId,
        Amount = 10200m,
        DateReceived = DateTime.Today.AddDays(-5),
        Notes = "Shoe deal + club appearance combo"
    },

    // Kawhi Leonard
    new IncomeRecord
    {
        UserAccountId = kawhi.UserAccountId,
        Amount = 7200m,
        DateReceived = DateTime.Today.AddDays(-10),
        Notes = "Load management wellness partnership"
    },

    // Giannis Antetokounmpo
    new IncomeRecord
    {
        UserAccountId = giannis.UserAccountId,
        Amount = 9500m,
        DateReceived = DateTime.Today.AddDays(-4),
        Notes = "Two-way star endorsement bonus"
    }
        };

        context.IncomeRecords.AddRange(incomes);
        context.SaveChanges();

        // -------------------------------
        // 6. TRANSACTIONS
        // -------------------------------

        var transactions = new List<TransactionRecord>
        {
            new TransactionRecord
            {
                UserAccountId = mj.UserAccountId,
                TransactionDate = DateTime.Today.AddDays(-2),
                Amount = 450m,
                Description = "Exclusive cigar lounge visit",
                Category = "Cigar Lounge Nights"
            },
            new TransactionRecord
            {
                UserAccountId = mj.UserAccountId,
                TransactionDate = DateTime.Today.AddDays(-1),
                Amount = 300m,
                Description = "Vintage jersey purchase",
                Category = "Shoe Collection"
            },

            new TransactionRecord
            {
                UserAccountId = lebron.UserAccountId,
                TransactionDate = DateTime.Today.AddDays(-3),
                Amount = 250m,
                Description = "Taco Tuesday groceries",
                Category = "Taco Tuesday Supplies"
            },
            new TransactionRecord
            {
                UserAccountId = lebron.UserAccountId,
                TransactionDate = DateTime.Today.AddDays(-1),
                Amount = 600m,
                Description = "AAU tournament travel",
                Category = "Kids AAU Travel"
            },

            new TransactionRecord
            {
                UserAccountId = kobe.UserAccountId,
                TransactionDate = DateTime.Today.AddDays(-4),
                Amount = 200m,
                Description = "Late night gym rental",
                Category = "Late Night Gym Sessions"
            },

            new TransactionRecord
            {
                UserAccountId = magic.UserAccountId,
                TransactionDate = DateTime.Today.AddDays(-7),
                Amount = 320m,
                Description = "Business lunch meeting",
                Category = "Business Lunches"
            },

            new TransactionRecord
            {
                UserAccountId = bird.UserAccountId,
                TransactionDate = DateTime.Today.AddDays(-5),
                Amount = 120m,
                Description = "Coffee and film session",
                Category = "Trash Talk Coffee"
            },

            new TransactionRecord
            {
                UserAccountId = shaq.UserAccountId,
                TransactionDate = DateTime.Today.AddDays(-2),
                Amount = 500m,
                Description = "DJ Diesel show expenses",
                Category = "DJ Diesel Gigs Travel"
            },

            new TransactionRecord
            {
                UserAccountId = curry.UserAccountId,
                TransactionDate = DateTime.Today.AddDays(-1),
                Amount = 350m,
                Description = "Team three-point contest side bets",
                Category = "Three-Point Contest Wagers"
            },

            new TransactionRecord
            {
                UserAccountId = ai.UserAccountId,
                TransactionDate = DateTime.Today.AddDays(-1),
                Amount = 275m,
                Description = "New tunnel fit outfit",
                Category = "Tunnel Fits"
            },
    // Russell Westbrook
    new TransactionRecord
    {
        UserAccountId = westbrook.UserAccountId,
        TransactionDate = DateTime.Today.AddDays(-2),
        Amount = 320m,
        Description = "Pre-game tunnel fit shopping spree",
        Category = "Pre-Game Fashion Tunnel Fits"
    },
    new TransactionRecord
    {
        UserAccountId = westbrook.UserAccountId,
        TransactionDate = DateTime.Today.AddDays(-1),
        Amount = 180m,
        Description = "Charity triple-double fundraiser expenses",
        Category = "Charity Triple-Double Events"
    },

    // George Mikan
    new TransactionRecord
    {
        UserAccountId = mikan.UserAccountId,
        TransactionDate = DateTime.Today.AddDays(-6),
        Amount = 240m,
        Description = "Vintage basketball clinic refreshments",
        Category = "Old-School Basketball Clinics"
    },
    new TransactionRecord
    {
        UserAccountId = mikan.UserAccountId,
        TransactionDate = DateTime.Today.AddDays(-3),
        Amount = 190m,
        Description = "Classic era memorabilia auction win",
        Category = "Classic Era Memorabilia"
    },

    // James Worthy
    new TransactionRecord
    {
        UserAccountId = worthy.UserAccountId,
        TransactionDate = DateTime.Today.AddDays(-4),
        Amount = 260m,
        Description = "Big game studio wardrobe refresh",
        Category = "Big Game Broadcast Dinners"
    },
    new TransactionRecord
    {
        UserAccountId = worthy.UserAccountId,
        TransactionDate = DateTime.Today.AddDays(-1),
        Amount = 210m,
        Description = "Showtime reunion travel deposit",
        Category = "Showtime Reunion Trips"
    },

    // John Stockton
    new TransactionRecord
    {
        UserAccountId = stockton.UserAccountId,
        TransactionDate = DateTime.Today.AddDays(-5),
        Amount = 150m,
        Description = "Coffee + film session for pick-and-roll study",
        Category = "Pick-and-Roll Film Study Snacks"
    },
    new TransactionRecord
    {
        UserAccountId = stockton.UserAccountId,
        TransactionDate = DateTime.Today.AddDays(-2),
        Amount = 220m,
        Description = "Youth league uniforms donation",
        Category = "Community Youth League Support"
    },

    // Shai Gilgeous-Alexander
    new TransactionRecord
    {
        UserAccountId = shai.UserAccountId,
        TransactionDate = DateTime.Today.AddDays(-3),
        Amount = 410m,
        Description = "Tunnel outfit from designer boutique",
        Category = "Designer Tunnel Fits"
    },
    new TransactionRecord
    {
        UserAccountId = shai.UserAccountId,
        TransactionDate = DateTime.Today.AddDays(-1),
        Amount = 350m,
        Description = "Off-season trainer session payment",
        Category = "Off-Season Skill Trainers"
    },

    // Reggie Miller
    new TransactionRecord
    {
        UserAccountId = reggie.UserAccountId,
        TransactionDate = DateTime.Today.AddDays(-4),
        Amount = 280m,
        Description = "Three-point camp facility rental",
        Category = "Three-Point Shooting Camps"
    },
    new TransactionRecord
    {
        UserAccountId = reggie.UserAccountId,
        TransactionDate = DateTime.Today.AddDays(-1),
        Amount = 95m,
        Description = "Broadcast prep latte + notes printouts",
        Category = "Broadcast Prep Coffee Runs"
    },

    // James Harden
    new TransactionRecord
    {
        UserAccountId = harden.UserAccountId,
        TransactionDate = DateTime.Today.AddDays(-2),
        Amount = 620m,
        Description = "VIP table at club appearance",
        Category = "Nightlife & Club Appearances"
    },
    new TransactionRecord
    {
        UserAccountId = harden.UserAccountId,
        TransactionDate = DateTime.Today.AddDays(-1),
        Amount = 210m,
        Description = "Film room snacks for stepback study",
        Category = "Stepback Film Study Snacks"
    },

    // Kawhi Leonard
    new TransactionRecord
    {
        UserAccountId = kawhi.UserAccountId,
        TransactionDate = DateTime.Today.AddDays(-5),
        Amount = 330m,
        Description = "Quiet cabin rental for load management",
        Category = "Load Management Getaways"
    },
    new TransactionRecord
    {
        UserAccountId = kawhi.UserAccountId,
        TransactionDate = DateTime.Today.AddDays(-2),
        Amount = 160m,
        Description = "Fun Guy neighborhood BBQ supplies",
        Category = "Fun Guy BBQs"
    },

    // Giannis Antetokounmpo
    new TransactionRecord
    {
        UserAccountId = giannis.UserAccountId,
        TransactionDate = DateTime.Today.AddDays(-3),
        Amount = 290m,
        Description = "Family dinner at Greek restaurant",
        Category = "Family Dinners & Dad Jokes"
    },
    new TransactionRecord
    {
        UserAccountId = giannis.UserAccountId,
        TransactionDate = DateTime.Today.AddDays(-1),
        Amount = 340m,
        Description = "Extra legroom flight for Eurostep practice tour",
        Category = "Eurostep Travel Costs"
    }

        };

        context.TransactionRecords.AddRange(transactions);
        context.SaveChanges();

    }


}