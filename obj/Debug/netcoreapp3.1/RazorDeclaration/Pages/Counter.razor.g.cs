#pragma checksum "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa2310aa003dd180664add244daa125e3819f3a0"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace blazorserver01.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\_Imports.razor"
using blazorserver01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\_Imports.razor"
using blazorserver01.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 119 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
      
    //Defining a valuable for Pattern button
    private bool addPatternHidden = true;
    private bool addCellsHidden =true;
    private string addCellsText = "Add Cells...";   
    private string patternType = "";
    // private string toadType = "toad"; 
    private string addPatternText ="Add Pattern...";
    private string textAreaCells = ""; 
    private int col { get; set; }=0;
    
    private  int row { get; set; } =0;
   
    private String theRadio="";

    private int currentCount = 0;

    private Data.Environment e = new Data.Environment(30,30);
       
    private string option = "";

    private bool CellClick(int row, int col)
    {
        e.onOff(row,col);
        return true;
    }
    private void IncrementCount()
    {
        currentCount++; 
        e.nextConwayStep();
    }

    private void ClickRadio(ChangeEventArgs args){
        theRadio = args.Value.ToString();
        currentCount++;
    }

    private void AddPattern(){
        e.put_pattern(row, col, patternType);
        row = col = 0;
    }
    private void AddPatternRow(){
        addPatternText = "Add Pattern " + (addPatternHidden ? "(-)" : "...");
        addPatternHidden = !addPatternHidden;
    }
    private void AddCells()
      {
          addCellsText = "Add cells " + (addCellsHidden ? "(-)" : "...");
   
          addCellsHidden = !addCellsHidden;
      }
   
      private void AddCell()
      {
          string[] cells = textAreaCells.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
   
          foreach (string cell in cells)
          {
              var dividedCells = cell.Split(',');
              e.insert(int.Parse(dividedCells[0]), int.Parse(dividedCells[1]), new blazorserver01.Data.BioUnit(int.Parse(dividedCells[0]),int.Parse(dividedCells[1]),e));
          }
   
          textAreaCells = "";
      } 


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
