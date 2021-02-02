using System.Linq;

namespace LinqToSqlCRUD
{
    public class DataAccessLayer
    {
        TeleponeDirectoryContextDataContext _context;
        public DataAccessLayer()
        {
            _context = new TeleponeDirectoryContextDataContext();
        }

        public void Add(Directory directory)
        {
            _context.Directories.InsertOnSubmit(directory);
            _context.SubmitChanges();
        }
        public void Update(Directory directory)
        {
            Directory foundDirectory=_context.Directories.Where(I=>I.DirectoryId == directory.DirectoryId).FirstOrDefault();
            if (foundDirectory != null)
            {
                foundDirectory.DirectoryId = directory.DirectoryId;
                foundDirectory.Firstname = directory.Firstname;
                foundDirectory.LastName = directory.LastName;
                foundDirectory.Telepone1 = directory.Telepone1;
                foundDirectory.Telepone2 = directory.Telepone2;
                foundDirectory.Telepone3 = directory.Telepone3;
                foundDirectory.EmailAddress = directory.EmailAddress;
                foundDirectory.FacebookURI = directory.FacebookURI;
                foundDirectory.TwiterURI = directory.TwiterURI;
                foundDirectory.YoutubeURI = directory.YoutubeURI;
                _context.SubmitChanges();
            }
        }
        public void Delete(int id)
        {
            Directory deleteDirectory = _context.Directories.Where(I=>I.DirectoryId == id).FirstOrDefault();
            if (deleteDirectory != null)
            {
                _context.Directories.DeleteOnSubmit(deleteDirectory);
                _context.SubmitChanges();
            }
        }
    }
}