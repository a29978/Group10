using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebGarten2.Demos.Todos.Model;
using WebGarten2.Html;

namespace WebGarten2.Demos.Todos.Views
{
    class EditView : HtmlDoc
    {
        public EditView(Playlist t)
            : base("Edit Playlist",
                H1(Text("Playlist")),
                P(Text(t.Name)),
                Form("POST",PlaylistResolveUri.editTodos(t),
                    Label("name","New Name:"),InputText("name"),
                    Label("desc","Description: "),InputText("desc"),
                    InputSubmit("Save")
                    )
                ){}
    }
}
