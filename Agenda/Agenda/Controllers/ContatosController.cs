using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agenda.Domain.Entities;
using Agenda.Infra.Context;
using Agenda.Presentation.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NHibernate;

namespace Agenda.Presentation.Controllers
{
    public class ContatosController : Controller
    {
        // GET: Contatos
        public ActionResult Index()
        {
            var session = ApplicationDBContext.OpenSession();

            var Contacts = session.Query<Contato>().ToList();

            var ContactsVM = Contacts.Select(x => new ContatoVM() { Nome = x.nome, Emails = x.emails.FirstOrDefault().email, Empresa = x.empresa, Endereco = x.endereco.endereco, Telefones = x.telefones.FirstOrDefault().numero }).ToList();


            return View(ContactsVM);
        }

        // GET: Contatos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Contatos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contatos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ContatoVM contato)
        {
            try
            {
                var session = ApplicationDBContext.OpenSession();

                var contatoCreate = ContatoVMToModel(contato);
                
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(contatoCreate);
                    transaction.Commit();
                }

                return RedirectToAction("Index");
            }
            catch (Exception exception)
            {
                return View();
            }
        }

        // GET: Contatos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Contatos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ContatoVM contato)
        {
            try
            {
                var session = ApplicationDBContext.OpenSession();
                
                var ContactUpdate = session.Get<Contato>(id);

                var contactVM = ContatoVMToModel(contato);

                ContactUpdate = contactVM;

                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(ContactUpdate);
                    transaction.Commit();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Contatos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Contatos/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private Contato ContatoVMToModel(ContatoVM contato)
        {
            var contatoModel = new Contato
            {
                contatoId = contato.contatoId,
                nome = contato.Nome,
                emails = new List<Email> { new Email { email = contato.Emails } },
                empresa = contato.Empresa,
                endereco = new Endereco { endereco = contato.Endereco },
                telefones = new List<Telefone> { new Telefone { numero = contato.Telefones } }
            };

            return contatoModel;
        }
    }
}