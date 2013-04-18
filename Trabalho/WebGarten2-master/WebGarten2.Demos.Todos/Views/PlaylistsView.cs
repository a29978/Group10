using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebGarten2.Demos.Todos.Model;
using WebGarten2.Html;

namespace WebGarten2.Demos.Todos.Views
{
    class PlaylistsView : HtmlDoc
    {
        public PlaylistsView(IEnumerable<Playlist> t)
            : base("PlaylistsView",
                H1(Text("PlaylistsView")),
                Ul(
                    t.Select(td => Li(A(PlaylistResolveUri.For(td),td.Name))).ToArray()
                    ),
                H2(Text("Create a new Playlists")),
                Form("post", "/playlists",
                    Label("name","Name:"),InputText("name")
                    //Label("desc","Description: "),InputText("desc")
                    )
                ){}
    }
}
