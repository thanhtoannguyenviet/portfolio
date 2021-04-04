using Pro.Data;
using Pro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pro.Services
{
    public class CertificationServiceImpl : CertificationService
    {
        private readonly MvcCertificationContext _context ;
        public CertificationServiceImpl(MvcCertificationContext context)
        {
            _context = context;
        }
        public CertificationServiceImpl()
        {
      
        }
        public List<Certification> FindAll()
        {
            var certification = _context.Certification.ToList();
            return certification;
        }
    }
}
