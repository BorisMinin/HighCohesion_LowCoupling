namespace HighCohesion_LowCoupling.Services.Cohesion
{
    public class StudentService
    {
        #region High Cohesion
        public Task GoToClass() // ходить на занятия
        {
            throw new NotImplementedException();
        }

        public Task TakeTests() // сдавать зачеты
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Low Cohesion
        public Task PayBribes() // даваит взятки
        {
            throw new NotImplementedException();
        }

        public Task WearChairs() // носить стулья
        {
            throw new NotImplementedException();
        }

        public Task WashFloors() // мыть полы
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}