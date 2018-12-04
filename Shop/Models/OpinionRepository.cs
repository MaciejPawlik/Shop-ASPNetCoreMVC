namespace Shop.Models
{
    public class OpinionRepository : IOpinionRepository
    {
        private readonly AppDBContext _appDBContext;

        public OpinionRepository(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        public void AddOpinion(Opinion opinon)
        {
            _appDBContext.Opinions.Add(opinon);
            _appDBContext.SaveChanges();
        }
    }
}
