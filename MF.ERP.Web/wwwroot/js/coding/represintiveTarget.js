var dataTable;
let controllerName = "/RepresintiveTarget";
$(document).ready(function () {
    loadDataTable();

});
$(document).on('click', ".btnAction", function () {
    let sid = $(this).attr('sid');
    $('#sId').val(sid); 
    drawModel("Create New", "Cancel");


});
function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": controllerName+"/GetAll", "dataSrc": ""
        },
        "order": [[0, 'desc']],
        "columns": [
            { "data": "id", "width": "10%" },
            { "data": "nameAr", "width": "45%" },
            { "data": "nameEn", "width": "45%" },
        ],
        "bDestroy": true
    });
}
// this is the id of the form
$("#frmCreate").submit(function (e) {

    e.preventDefault(); // avoid to execute the actual submit of the form.

    var form = $(this);
    let actionUrls = controllerName+"/Create";
    //var actionUrl = form.attr('action');

    $.ajax({
        type: "POST",
        url: actionUrls,
        data: form.serialize(), // serializes the form's elements.
        success: function (data) {
            if (data.isSuccess) {
                showSuccessMessage();
                loadDataTable();
            } else {
                showErrorMessage();
            }
        }
    });

});

function drawModel(mTitle, mBtnSecondary, mData, callBack = null) {
    $('#exampleModalLongTitle').text(mTitle);

    $('#btnSecondary').text(mBtnSecondary);
    $('#results').html(mData);
    $('#exampleModalCenter').modal('show');
    if (callBack != null) {
        callBack();
    }
}
function hideModel() {
    $('#exampleModalCenter').modal('hide');
}