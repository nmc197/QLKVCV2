#pragma checksum "C:\Users\Cuong\source\repos\QuanLyKVC\QuanLyKVC\Views\Shared\Core\NguoiDung\AdminList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d37164b52e09c9b727b8d09a1e4bb2d0028dcc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Core_NguoiDung_AdminList), @"mvc.1.0.view", @"/Views/Shared/Core/NguoiDung/AdminList.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Cuong\source\repos\QuanLyKVC\QuanLyKVC\Views\_ViewImports.cshtml"
using QuanLyKVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cuong\source\repos\QuanLyKVC\QuanLyKVC\Views\_ViewImports.cshtml"
using QuanLyKVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d37164b52e09c9b727b8d09a1e4bb2d0028dcc9", @"/Views/Shared/Core/NguoiDung/AdminList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d988f997541997c8748f33a2cbcaffc738a19951", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Core_NguoiDung_AdminList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("updateItem(updatingItemId); return false;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    \r\n");
#nullable restore
#line 3 "C:\Users\Cuong\source\repos\QuanLyKVC\QuanLyKVC\Views\Shared\Core\NguoiDung\AdminList.cshtml"
      
        ViewData["Title"] = "Ng?????i d??ng";
        Layout = "_NovaticAdmin";
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    

    <div class=""page-header card"">
        <div class=""col"">
            <div class=""page-header-title"">
                <i class=""fa fa-server""></i>
                <div class=""d-inline"">
                    <h3 class=""tableTitle"">Ng?????i d??ng</h3>
                </div>
            </div>

            <a href=""#"" id=""btnAddItem"" onclick=""editItem(0);"" class=""btn btn-brand btn-elevate btn-icon-sm"">
                <i class=""fa fa-plus""></i>
                <span class='hideOnMobile'>New Record</span>
            </a>
        </div>
    </div>

    <div class=""pcoded-inner-content"">
        <div class=""main-body"">
            <div class=""page-wrapper"">

                <!-- Page-body start -->
                <div class=""page-body"">
                    <div class=""card"">
                        <div class=""card-block novaticContainer"">
                            <div class=""dt-responsive table-responsive"">

                                <table id=""tableData"" class=""table tab");
            WriteLiteral(@"le-hover"">
                                    <thead>
                                        <tr>
                                            <th>Index</th>
						<th>ten</th>
						<th>tenDangNhap</th>
						<th>matKhau</th>

                                            <th>Detail</th>
                                            <th>Delete</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                    </tbody>
                                    <tfoot>
                                        <tr>
                                            <th>Index</th>
						<th>ten</th>
						<th>tenDangNhap</th>
						<th>matKhau</th>

                                            <th> </th>
                                            <th> </th>
                                        </tr>
                                    </tfoot>
                                </table>

               ");
            WriteLiteral(@"                 <div class=""modal fade"" id=""modal-id"">
                                    <div class=""modal-dialog modal-lg"">
                                        <div class=""modal-content"">
                                            <div class=""modal-header bg-gradient-info"">
                                                <button type=""button"" class=""close"" data-dismiss=""modal""
                                                    aria-hidden=""true"">&times;</button>
                                                <h4 class=""modal-title""><i class=""fa fa-edit""></i> Detail item</h4>
                                            </div>
                                            <div class=""modal-body"">


                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d37164b52e09c9b727b8d09a1e4bb2d0028dcc97914", async() => {
                WriteLiteral(@"

                                                    <!-- <div class=""form-group"">
                                                                        <label for="""">Apply type Id</label>
                                                                        <input type=""text"" class=""form-control""
                                                                            id=""NguoiDungId"" required readonly
                                                                            placeholder="""">
                                                                    </div>


                                                                    <div class='form-group'>
                                                                        <label for=''>Apply type name</label>
                                                                        <input type='text' class='form-control'
                                                                            id='NguoiDungName' required
       ");
                WriteLiteral(@"                                                                     placeholder=''>
                                                                    </div>


                                                                    <div class='form-group'>
                                                                        <label for=''>Description</label>
                                                                        <input type='text' class='form-control'
                                                                            id='NguoiDungDescription'
                                                                            placeholder=''>
                                                                    </div>


                                                                    <div class='form-group'>
                                                                        <label for=''>CreatedTime</label>
                                                                   ");
                WriteLiteral(@"     <input type='text'
                                                                            class='form-control datetimepicker'
                                                                            id='NguoiDungCreatedTime'
                                                                            placeholder=''>
                                                                    </div>


                                                                    <div class='form-group' style="""">
                                                                        <label for=''>Active</label>
                                                                        <input type='text' class='form-control'
                                                                            id='NguoiDungActive' readonly
                                                                            placeholder=''>
                                                                    </div>
                ");
                WriteLiteral(@"                                                    -->
                                                    




                                                    <input style=""display:none"" id=""hiddenSubmit"" type=""submit""
                                                        class=""btn btn-default"" value=""Save changes"">
                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


                                            </div>
                                            <div class=""modal-footer"">
                                                <button type=""button"" class=""btn btn-default""
                                                    data-dismiss=""modal"">Close</button>
                                                <button type=""button"" class=""btn btn-primary"" id=""btnUpdateItem""
                                                    onclick=""document.getElementById('hiddenSubmit').click();"">Save
                                                    changes</button>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
                             
    
    <script>
    ");
            WriteLiteral(@"    var hiddenItem = [""maND"",""maNV"",""maQuyen""];
        var showItem = [""ten"",""tenDangNhap"",""matKhau""];
        var dataSource = [];
        var updatingItemId = 0;
        var tableUpdating = 0;
        var table;

        $(document).ready(function () {
            // Load data
            //loadData();
            setTimeout(function(){loadData();}, 460);                

            // includeLibrary();

            // Datetime picker
            $('.datetimepicker').datetimepicker({
                format: 'YYYY-MM-DD HH:mm:ss'
            });

            $('.dataSelect').select2();

            $("".datetimepicker"").on('dp.change', function (e) {
                // console.log(this.value);
                this.value = moment(this.value).format(""YYYY-MM-DD HH:mm:ss"");
                // console.log(this.value);
            })

        });


        function loadData() {
            $.ajax({
                url: systemURL+ ""NguoiDung/api/list"",
                type: ""GET"",");
            WriteLiteral(@"
                contentType: ""application/json"",
                success: function (responseData) {
                    // debugger;
                    var data = responseData.data;
                    dataSource = data;




                    data.forEach(function (item, index) {
                        // console.log(item, index);
                        var rowContent = """";
                        rowContent += ""<td style='text-align: center;'>"" + (index + 1) + ""</td>"";
                        for (var key in item) {
                            if (item.hasOwnProperty(key)) {
                                // console.log(key + "" -> "" + item[key]);
                                if (showItem.includes(key)) {
                                    if (key != ""photo"") {
                                        rowContent += ""<td class='row"" + item.id + ""-column column-"" + key + ""' property='"" + key + ""'>"" + item[key] + ""</td>"";
                                    }
                      ");
            WriteLiteral(@"              else {
                                        rowContent += ""<td class='row"" + item.id + ""-column column-"" + key + ""' property='"" + key + ""'><img src='"" + item[key] + ""' style='height:80px;' /></td>"";
                                    }
                                }
                            }
                        }
                        rowContent += ""<td style='text-align: center;'><a onclick='editItem("" + item.id + "")'><i class='fa fa-edit fa-2x' style='color:#03a9f4'></i></a></td>"";
                        rowContent += ""<td style='text-align: center;'><a onclick='deleteItem("" + item.id + "")'><i class='fa fa-trash fa-2x' style='color:#e91e63'></i></a></td>"";
                        
                        var newRow = ""<tr id='row""+item.id+""' >"" + rowContent + ""</tr>"";
                        $(newRow).appendTo($(""#tableData tbody""));
                        
                        // $(""#tableData #dummyRow"").after(""<tr id='row""+item.id+""' >"" + rowContent + ""</tr");
            WriteLiteral(@">"");
                    });

                    //Init datatable
                    if (tableUpdating === 0) {
                        initTable();
                    }

                    //update data with foreign key
                    updateTable();
                },
                error: function (e) {
                    //console.log(e.message);
                    initTable();
                }
            });
        }

        function initTable(){
            table = $('#tableData').DataTable({
                aLengthMenu: [
                    [10, 25, 50, 100, 200, -1],
                    [10, 25, 50, 100, 200, 'T???t c???']
                ],
                'order': [
                    [1, 'desc']
                ]
            });


            
            table.on('order.dt search.dt', function() {
                table.column(0, {
                    search: 'applied',
                    order: 'applied'
                }).nodes().each(function(cell");
            WriteLiteral(@", i) {
                    cell.innerHTML = i + 1;
                });
            }).draw();

            $('#tableData tfoot th:not(:last-child):not(:nth-last-child(2))').each(function() {
                var title = $(this).text();
                $(this).html(""<input type='text' class='tableFooterFilter' placeholder=' ' />"");
            });

            table.columns().every(function() {
                var that = this;

                $('input', this.footer()).on('keyup change', function() {
                    if (that.search() !== this.value) {
                        that
                            .search(this.value)
                            .draw();
                    }
                });
            });
        }

        function editItem(id) {
            updatingItemId = id;
            $(""#modal-id"").modal('show');

            let obj = getItemById(id);
            		$(""#NguoiDungMaND"").val(id > 0 ? obj.maND : """");
		$(""#NguoiDungTen"").val(id > 0 ? obj.ten :");
            WriteLiteral(@" """");
		$(""#NguoiDungTenDangNhap"").val(id > 0 ? obj.tenDangNhap : """");
		$(""#NguoiDungMatKhau"").val(id > 0 ? obj.matKhau : """");
		$(""#NguoiDungMaNV"").val(id > 0 ? obj.maNV : """");
		$(""#NguoiDungMaQuyen"").val(id > 0 ? obj.maQuyen : """");

            // $(""#NguoiDungId"").val(id > 0 ? obj.id : """");
            // $(""#NguoiDungName"").val(id > 0 ? obj.name : """");
            // $(""#NguoiDungDescription"").val(id > 0 ? obj.description : """");
            // $(""#NguoiDungCreatedTime"").val(id > 0 ? obj.createdTime : """");
            // $(""#NguoiDungActive"").val(id > 0 ? obj.active : """");

            if(id==0){
                $(""#NguoiDungActive"").val(1);
                $(""#NguoiDungCreatedTime"").val(new Date().toISOString().replace(/T/, ' ').replace(/\..+/, ''));
            }
            else{
                // correcting data
                //$('#buyProvinceId').val(obj.provinceId.split("", "")).trigger('change');
                
            }
            formatNumber();
        }


        fu");
            WriteLiteral(@"nction updateItem(id) {
            var actionName = (id == 0 ? ""Create"" : ""Update"");
            let obj = getItemById(id);
            let objName = id > 0 ? obj.name : "" "";

            validateInputNumber();

            // ""id"": $(""#NguoiDungId"").val(),
            // ""name"": $(""#NguoiDungName"").val(),
            // ""description"": $(""#NguoiDungDescription"").val(),
            // ""createdTime"": $(""#NguoiDungCreatedTime"").val(),
            // ""active"": $(""#NguoiDungActive"").val()
            var updatingObj = {
                		""maND"": $(""#NguoiDungMaND"").val(),
		""ten"": $(""#NguoiDungTen"").val(),
		""tenDangNhap"": $(""#NguoiDungTenDangNhap"").val(),
		""matKhau"": $(""#NguoiDungMatKhau"").val(),
		""maNV"": $(""#NguoiDungMaNV"").val(),
		""maQuyen"": $(""#NguoiDungMaQuyen"").val(),

            };

            // correcting data
            //updatingObj.provinceId = updatingObj.provinceId.join("", "");
            

            Swal.fire({
                title: 'Are you sure?',
                te");
            WriteLiteral(@"xt: ""Performing "" + actionName + "" item "" + objName,
                icon: 'info',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#443',
                confirmButtonText: 'Yes, confirm!'
            }).then((result) => {
                if (result.value) {
                    $(""#modal-id"").modal('hide');

                    //CALL AJAX TO UPDATE
                    if (id > 0) {
                        $.ajax({
                            url: systemURL+ ""NguoiDung/api/update"",
                            type: ""POST"",
                            contentType: ""application/json"",
                            data: JSON.stringify(updatingObj),
                            success: function (responseData) {
                                // debugger;
                                if (responseData.status == 200 && responseData.message === ""SUCCESS"") {
                                    Swal.fire(
                ");
            WriteLiteral(@"                        'Updated!',
                                        'Item ' + objName + ' has been successfully updated!',
                                        'success'
                                    );
                                    updateTable(id,updatingObj,""update"");
                                    var updatedItemIndex= dataSource.findIndex(item => parseInt(item.id) === id);
                                    dataSource[updatedItemIndex] = updatingObj;
                                }
                            },
                            error: function (e) {
                                //console.log(e.message);
                                Swal.fire(
                                    'Error!',
                                    'Could\' update item, please check your data',
                                    'error'
                                );
                            }
                        });
                    };

          ");
            WriteLiteral(@"          //CALL AJAX TO CREATE
                    if (id == 0) {
                        updatingObj.id = 1;
                        delete updatingObj[""id""]
                        updatingObj.active = 1;
                        updatingObj.createdTime = new Date();
                        console.log(updatingObj);
                        $.ajax({
                            url:systemURL + ""NguoiDung/api/add"",
                            type: ""POST"",
                            contentType: ""application/json"",
                            data: JSON.stringify(updatingObj),
                            success: function (responseData) {
                                // debugger;
                                if (responseData.status == 201 && responseData.message === ""CREATED"") {
                                    Swal.fire(
                                        'Created!',
                                        'New item has been successfully created!',
                            ");
            WriteLiteral(@"            'success'
                                    );
                                    updatingObj = responseData.data;
                                    dataSource.push(updatingObj);
                                    updateTable(0,updatingObj,""add"");
                                }
                            },
                            error: function (e) {
                                //console.log(e.message);
                                Swal.fire(
                                    'Error!',
                                    'Could\' create item, please check your data',
                                    'error'
                                );
                            }
                        });
                    }
                }
            })
        }

        function deleteItem(id) {
            let obj = getItemById(id);
            Swal.fire({
                title: 'Are you sure?',
                text: ""You won't be able to reve");
            WriteLiteral(@"rt this!"",
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#d33',
                cancelButtonColor: '#3085d6',
                confirmButtonText: 'Yes, delete it!'
            }).then((result) => {
                if (result.value) {

                    //CALL AJAX TO DELETE
                    $.ajax({
                        url: systemURL + ""NguoiDung/api/delete"",
                        type: ""POST"",
                        contentType: ""application/json"",
                        data: JSON.stringify({ ""id"": id }),
                        success: function (responseData) {
                            // debugger;
                            if (responseData.status == 200 && responseData.message === ""SUCCESS"") {
                                Swal.fire(
                                    'Deleted!',
                                    'Item ' + obj.name + ' has been deleted.',
                                    'success");
            WriteLiteral(@"'
                                );
                                updateTable(id,0,""delete"");
                            }
                        },
                        error: function (e) {
                            //console.log(e.message);
                            Swal.fire(
                                'Error!',
                                'Item ' + obj.name + ' can\'t be deleted.',
                                'error'
                            );
                        }
                    });

                }
            })
        }

        function updateTable(id,obj,action) {
            if(action === ""delete""){ 
                table.row(""#row""+id).remove().draw();
            }

            if(action === ""add""){
                console.log(""Added:""+obj);

                //var addedItems = [obj];
                var addedItems = obj;
                var addedValues =[];


                addedItems.forEach(function (item, index) {
    ");
            WriteLiteral(@"                // console.log(item, index);
                    var rowContent = """";
                    addedValues.push(""<td style='text-align: center;'></td>"");
                    for (var key in item) {
                        if (item.hasOwnProperty(key)) {
                            // console.log(key + "" -> "" + item[key]);
                            if (showItem.includes(key)) {
                                if (key != ""photo"") {
                                    addedValues.push (""<td class='row"" + item.id + ""-column column-"" + key + ""' property='"" + key + ""'>"" + item[key] + ""</td>"");
                                }
                                else {
                                    addedValues.push (""<td class='row"" + item.id + ""-column column-"" + key + ""' property='"" + key + ""'><img src='"" + item[key] + ""' style='height:80px;' /></td>"");
                                }
                            }
                        }
                    }
                   ");
            WriteLiteral(@" addedValues.push(""<td style='text-align: center;'><a onclick='editItem("" + item.id + "")'><i class='fa fa-edit fa-2x' style='color:#03a9f4'></i></a></td>"");
                    addedValues.push(""<td style='text-align: center;'><a onclick='deleteItem("" + item.id + "")'><i class='fa fa-trash fa-2x' style='color:#e91e63'></i></a></td>"");

                    table.row.add(addedValues).draw();
                });
                // location.reload();
            }

            if(action === ""update""){
                // alert(id);
                $("".row""+id+""-column"").each(function(){
                    var propertyName = $(this).attr(""property"");
                    console.log(propertyName);
                    
                    for (var key in obj) {
                        if (key === propertyName && obj.hasOwnProperty(key)) {
                            if(key === ""photo""){
                                $(this).children().attr(""src"",obj[key]);
                            }
          ");
            WriteLiteral(@"                  else{
                                this.innerText = obj[key];
                            }
                        }
                    }

                });
            }

            //Update columns with foreign key
            // var NO_FKFKUpdateSelector = 'tr';
            // if( !(typeof(id) === 'undefined')) {
            //     NO_FKFKUpdateSelector = '#row'+id;
            // }
            // $('#tableData tbody '+NO_FKFKUpdateSelector+' td[property=NO_FKId]').each(function(){
            //     // debugger;
            //     var NguoiDungId = parseInt($(this).attr('class').replace('row','').replace('-column',''));
            //     var NguoiDungObj = getItemById(NguoiDungId);
            //     var NO_FKId = parseInt(NguoiDungObj.NO_FKId);
            //     var NO_FKObj = NO_FKData.find(item => parseInt(item.id) === NO_FKId);
            //     $(this).text(NO_FKObj.name);
            //     // console.log('FK updated for Staff '+NguoiDungId);
      ");
            WriteLiteral(@"      // });
            
            
            formatNumber();
        }


        function getItemById(id) {
            const result = dataSource.find(item => parseInt(item.id) === id);
            return result;
        } 

            
    </script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
