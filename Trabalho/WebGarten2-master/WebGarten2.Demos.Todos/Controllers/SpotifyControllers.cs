using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebGarten2.Demos.Todos.Model;
using WebGarten2.Demos.Todos.Views;
using WebGarten2.Html;

namespace WebGarten2.Demos.Todos.Controllers
{
    class SpotifyControllers
    {
        private readonly InterfaceShared<Playlist> _repo;

        public SpotifyControllers()
        {
            _repo = PlaylistMemoryRepositoryLocator.Get();
        }

        [HttpMethod("GET", "/playlists/{Id}")]
        public HttpResponseMessage Get(int id)
        {
            var td = _repo.GetById(id);
            return td == null ? new HttpResponseMessage(HttpStatusCode.NotFound) : 
                new HttpResponseMessage{
                    Content = new PlaylistView(td).AsHtmlContent()
                };
        }

        [HttpMethod("GET", "/playlists")]
        public HttpResponseMessage Get()
        {
            return new HttpResponseMessage{
                Content = new PlaylistsView(_repo.GetAll()).AsHtmlContent()
        };
        }

        [HttpMethod("POST", "/playlists")]
        public HttpResponseMessage Post(NameValueCollection content)
        {
            
            //var desc = content["desc"];
            var name = content["name"];
            if (name == null)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
            var td = new Playlist { Name=name };
            _repo.Add(td);
            var resp = new HttpResponseMessage(HttpStatusCode.SeeOther);
            resp.Headers.Location = new Uri(PlaylistResolveUri.For(td));
            return resp;
        }

        [HttpMethod("GET", "/edit/{Id}")]
        public HttpResponseMessage Edit(int Id) 
        {
            var td = _repo.GetById(Id);
            return td == null ? new HttpResponseMessage(HttpStatusCode.NotFound) :
                new HttpResponseMessage
                {
                    Content = new EditView(td).AsHtmlContent()
                };
        } 

        [HttpMethod("POST","/editPost/{Id}")]
        public HttpResponseMessage EditPost(NameValueCollection content, int Id) 
        {
            var desc=content["desc"];
            var name=content["name"];
            Playlist pl = _repo.GetById(Id);

            if (pl == null) return new HttpResponseMessage(HttpStatusCode.NotFound);
            if(name!="")
            pl.Name = name;
            if(desc!="")
            pl.Description = desc;
            return new HttpResponseMessage
                {
                    Content = new PlaylistView(pl).AsHtmlContent()
                };

        }

        [HttpMethod("GET","/delete/{Id}")]
        public HttpResponseMessage Delete(int Id) 
        {
            if (_repo.GetById(Id) == null) return new HttpResponseMessage(HttpStatusCode.NotFound);
           // Playlist pl = _repo.GetById(Id);
            _repo.Remove(_repo.GetById(Id));
            return new HttpResponseMessage
            {
                Content = new PlaylistsView(_repo.GetAll()).AsHtmlContent()
            };
        }


    }
}
