using Fitness.BL.Model;

namespace Fitness.BL.Controller
{
    public class ExerciseController:ControllerBase
    {
        private const string EXERCISES_FILE_NAME = "exercises.dat";
        private const string ACTIVITYS_FILE_NAME = "activitys.dat";
        private readonly User user;
        public List<Exercise> Exercises { get; }
        public List<Activity> Activities { get; }

        public ExerciseController(User user)
        {
            this.user = user??throw new ArgumentNullException(nameof(user));
            Exercises = GetAllExercises();
            Activities = GetAllActivities();
        }

        private List<Activity> GetAllActivities()
        {
            return Load<List<Activity>>(ACTIVITYS_FILE_NAME) ?? new List<Activity>();
        }

        public void Add(Activity activity, DateTime begin, DateTime end)
        {
            var act = Activities.SingleOrDefault(a => a.Name == activity.Name);
            if(act == null)
            {
                Activities.Add(activity);

                var execise = new Exercise(begin, end, activity, user);
                Exercises.Add(execise);
            }
            else
            {
                var execise = new Exercise(begin, end, act, user);
                Exercises.Add(execise);
            }
            Save();
        }

        private List<Exercise> GetAllExercises()
        {
            return Load<List<Exercise>>(EXERCISES_FILE_NAME)??new List<Exercise>();
        }

        private void Save()
        {
            Save(EXERCISES_FILE_NAME,Exercises);
            Save(ACTIVITYS_FILE_NAME,Activities);
        }
    }
}
