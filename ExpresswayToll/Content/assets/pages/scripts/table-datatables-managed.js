var TableDatatablesManaged = function () {
    var initTable1 = function () {
        var table = $('#List');
        table.dataTable({
            "language": {
                "aria": {
                    "sortAscending": ": 升序排列",
                    "sortDescending": ": 降序排列"
                },
                "emptyTable": "无数据",
                "info": "共 _TOTAL_ 条，当前显示 _START_ - _END_ 。",
                "infoEmpty": "无数据",
                "infoFiltered": "(从 _MAX_ 条中检索)",
                "lengthMenu": "每页显示 _MENU_ 条",
                "search": "查找:",
                "zeroRecords": "查询不到符合指定条件的数据",
                "paginate": {
                    "previous": "上一页",
                    "next": "下一页",
                    "last": "末页",
                    "first": "首页"
                }
            },

            "bStateSave": true, 

            "lengthMenu": [
                [5, 15, 20, -1],
                [5, 15, 20, "All"] 
            ],
            "pageLength": 5,
            "order": [
                [1, "asc"]
            ] 
        });
      }
        return {

            //main function to initiate the module
            init: function () {
                if (!jQuery().dataTable) {
                    return;
                }
                initTable1();
            }
        };
    }();

    if (App.isAngularJsApp() === false) {
        jQuery(document).ready(function () {
            TableDatatablesManaged.init();
        });
    }
