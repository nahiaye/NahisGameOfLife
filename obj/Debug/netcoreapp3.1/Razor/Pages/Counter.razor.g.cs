#pragma checksum "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa2310aa003dd180664add244daa125e3819f3a0"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h1>Game of Live</h1>\n\n<hr>\n\n");
#nullable restore
#line 7 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
  
    if(currentCount==0){
        e.put_pattern(6,6,"pentadecathlon");
    }
    int svgh = e.total_of_rows()*9+2;
    int svgw = e.total_of_cols()*9+2;

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "\n");
            __builder.OpenElement(2, "svg");
            __builder.AddAttribute(3, "width", 
#nullable restore
#line 15 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
             svgw

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(4, "height", 
#nullable restore
#line 15 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
                            svgh

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(5, "\n    ");
            __builder.AddMarkupContent(6, "<defs>\n        <filter id=\"myBlur\" x=\"0\" y=\"0\">\n            <feGaussianBlur in=\"SourceGraphic\" stdDeviation=\"3\"></feGaussianBlur>\n        </filter>\n    </defs>\n");
#nullable restore
#line 21 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
     for(var i=0; i<@e.total_of_rows() ; i++)
    {
        for(var j=0; j<@e.total_of_cols(); j++)
        {
            int cy = (i*9+4+1);
            int cx = (j*9+4+1);
            int idx = i;
            int jdx = j;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
             if(e.biounit(i,j)!=null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "                ");
            __builder.OpenElement(8, "circle");
            __builder.AddAttribute(9, "cx", 
#nullable restore
#line 31 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
                             cx

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "cy", 
#nullable restore
#line 31 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
                                      cy

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "r", "4");
            __builder.AddAttribute(12, "fill", "#90FA90");
            __builder.AddAttribute(13, "filter", "url(#myBlur)");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
                                                ()=>CellClick(idx,jdx)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n");
#nullable restore
#line 33 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                ");
            __builder.OpenElement(17, "circle");
            __builder.AddAttribute(18, "cx", 
#nullable restore
#line 36 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
                             cx

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(19, "cy", 
#nullable restore
#line 36 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
                                      cy

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(20, "r", "4");
            __builder.AddAttribute(21, "fill", "#909090");
            __builder.AddAttribute(22, "filter", "url(#myBlur)");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
                                                ()=>CellClick(idx,jdx)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n");
#nullable restore
#line 38 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
             
        }
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(25, " \n\n");
            __builder.OpenElement(26, "table");
            __builder.AddAttribute(27, "class", "environment");
            __builder.AddMarkupContent(28, "\n");
#nullable restore
#line 44 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
     for(var i=0; i<@e.total_of_rows(); i++)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "         ");
            __builder.OpenElement(30, "tr");
            __builder.AddMarkupContent(31, "\n");
#nullable restore
#line 47 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
              for(var j=0; j<@e.total_of_cols(); j++)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
                 if(e.biounit(i,j)!=null)
                    { 

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(32, "                        <td class=\"cell alive\"></td> \n");
#nullable restore
#line 52 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
                    } 
                else 
                    { 

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(33, "                        <td class=\"cell dead\"></td> \n");
#nullable restore
#line 56 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
                      
            }      

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n");
#nullable restore
#line 59 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n\n");
            __builder.OpenElement(37, "p");
            __builder.AddMarkupContent(38, "\n    ");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "type", "radio");
            __builder.AddAttribute(41, "name", "myradiobtn");
            __builder.AddAttribute(42, "checked", 
#nullable restore
#line 64 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
                                                     theRadio.Equals("step")

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(43, "value", "step");
            __builder.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 64 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
                                                                                                       ClickRadio

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n    Step by step\n    ");
            __builder.OpenElement(46, "input");
            __builder.AddAttribute(47, "type", "radio");
            __builder.AddAttribute(48, "name", "myradiobtn");
            __builder.AddAttribute(49, "checked", 
#nullable restore
#line 66 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
                                                     theRadio.Equals("many")

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(50, "value", "many");
            __builder.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
                                                                                                       ClickRadio

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n    Several steps\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\n\n\n");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "style", "display:" + (
#nullable restore
#line 72 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
                      theRadio.Equals("many")?"":"none"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(56, "\n");
            __builder.AddMarkupContent(57, "<h5>Cycle Specification</h5>\nNumber of cycles;\n\n");
            __builder.OpenElement(58, "select");
            __builder.AddAttribute(59, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 76 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
                 option

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => option = __value, option));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(61, "\n");
            __builder.OpenElement(62, "option");
            __builder.AddAttribute(63, "value", "1");
            __builder.AddContent(64, "1st");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\n");
            __builder.OpenElement(66, "option");
            __builder.AddAttribute(67, "value", "2");
            __builder.AddContent(68, "2nd");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\n");
            __builder.OpenElement(70, "option");
            __builder.AddAttribute(71, "value", "3");
            __builder.AddContent(72, "3rd");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\n");
            __builder.OpenElement(74, "option");
            __builder.AddAttribute(75, "value", "4");
            __builder.AddContent(76, "4th");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\n");
            __builder.OpenElement(78, "option");
            __builder.AddAttribute(79, "value", "5");
            __builder.AddContent(80, "5th");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\n<br>\nAdd option ");
            __builder.AddContent(83, 
#nullable restore
#line 84 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
            option

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(84, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\n\n        ");
            __builder.OpenElement(86, "button");
            __builder.AddAttribute(87, "class", "btn btn-primary");
            __builder.AddAttribute(88, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 88 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
                                                    IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(89, "Next");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\n\n");
            __builder.AddMarkupContent(91, "<a class=\"btn btn-primary\" href=\"https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life\" target=\"_blank\">\n    Look for Patterns in Wikipedia\n</a>\n\n        ");
            __builder.OpenElement(92, "button");
            __builder.AddAttribute(93, "class", "btn btn-primary");
            __builder.AddAttribute(94, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 96 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
                                                    AddPatternRow

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(95, 
#nullable restore
#line 96 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
                                                                    addPatternText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(96, " \n\n");
            __builder.OpenElement(97, "div");
            __builder.AddAttribute(98, "class", "my-3");
            __builder.AddAttribute(99, "style", "display:" + (
#nullable restore
#line 98 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
                                     addPatternHidden == true ? "none" : "block"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(100, "\n            ");
            __builder.OpenElement(101, "label");
            __builder.AddContent(102, " row ");
            __builder.OpenElement(103, "input");
            __builder.AddAttribute(104, "class", "form-control");
            __builder.AddAttribute(105, "type", "number");
            __builder.AddAttribute(106, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 99 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
                                                                         row

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(107, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => row = __value, row, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddContent(108, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\n            ");
            __builder.OpenElement(110, "label");
            __builder.AddContent(111, " col ");
            __builder.OpenElement(112, "input");
            __builder.AddAttribute(113, "class", "form-control");
            __builder.AddAttribute(114, "type", "number");
            __builder.AddAttribute(115, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 100 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
                                                                         col

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(116, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => col = __value, col, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddContent(117, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\n            ");
            __builder.OpenElement(119, "label");
            __builder.AddMarkupContent(120, "Pattern \n                ");
            __builder.OpenElement(121, "select");
            __builder.AddAttribute(122, "class", "form-control");
            __builder.AddAttribute(123, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 102 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
                                                      patternType

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(124, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => patternType = __value, patternType));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(125, "\n                    ");
            __builder.OpenElement(126, "option");
            __builder.AddAttribute(127, "value", "pentadecathlon");
            __builder.AddContent(128, "Pentadecathlon");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\n                    ");
            __builder.OpenElement(130, "option");
            __builder.AddAttribute(131, "value", "toad");
            __builder.AddContent(132, "Toad");
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\n                    ");
            __builder.OpenElement(134, "option");
            __builder.AddAttribute(135, "value", "ship");
            __builder.AddContent(136, "Ship");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\n        ");
            __builder.OpenElement(140, "button");
            __builder.AddAttribute(141, "class", "btn btn-primary");
            __builder.AddAttribute(142, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 108 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
                                                      AddPattern

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(143, " Add ");
            __builder.AddContent(144, 
#nullable restore
#line 108 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
                                                                        patternType

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(145, " Pattern");
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\n    ");
            __builder.OpenElement(147, "button");
            __builder.AddAttribute(148, "class", "btn btn-primary");
            __builder.AddAttribute(149, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 109 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
                                              AddCells

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(150, 
#nullable restore
#line 109 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
                                                         addCellsText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\n    ");
            __builder.OpenElement(152, "div");
            __builder.AddAttribute(153, "class", "my-3");
            __builder.AddAttribute(154, "style", "display:" + (
#nullable restore
#line 110 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
                                       addCellsHidden == true ? "none" : "block"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(155, "\n        ");
            __builder.OpenElement(156, "label");
            __builder.AddContent(157, "Enter Cells(x,y) ");
            __builder.OpenElement(158, "textarea");
            __builder.AddAttribute(159, "class", "form-control");
            __builder.AddAttribute(160, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 111 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
                                                                      textAreaCells

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(161, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => textAreaCells = __value, textAreaCells));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(162, "\n            ");
            __builder.OpenElement(163, "button");
            __builder.AddAttribute(164, "class", "btn btn-primary mt-2");
            __builder.AddAttribute(165, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 112 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Game-Of-Life-master\Pages\Counter.razor"
                                                           AddCell

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(166, "Add cell");
            __builder.CloseElement();
            __builder.AddMarkupContent(167, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(168, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(169, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(170, "\n\n<hr>");
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
