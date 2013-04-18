using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebGarten2.Demos.Todos.Model;
using WebGarten2.Html;

namespace WebGarten2.Demos.Todos.Views
{
    class PlaylistView : HtmlDoc
    {
        public PlaylistView(Playlist t)
            : base("Playlist",
                H1(Text("Playlist")),
                P(Text(t.Name)),
                A(PlaylistResolveUri.ForTodos(),"ToDo list"),
                H1(Text("")),
                A(PlaylistResolveUri.edit(t), "Edit list"),
                H1(Text("")),
                A(PlaylistResolveUri.delete(t), "Delete list")
                ){}
    }
}
