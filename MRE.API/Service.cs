namespace MRE.API
{
    public class Service
    {
        private readonly Repo.Repo _repo;

        public Service(Repo.Repo repo)
        {
            _repo = repo;
        }
    }
}