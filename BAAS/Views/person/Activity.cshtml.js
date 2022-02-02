


var chartData = {
labels: [@foreach(var user in Model) {@Html.DisplayFor(u => user.creationdate);}
],
datasets: [
        {
            
            label: "My Second dataset",
            fillColor: "rgba(151,187,205,0.2)",
            strokeColor: "rgba(151,187,205,1)",
            pointColor: "rgba(151,187,205,1)",
            pointStrokeColor: "#fff",
            pointHighlightFill: "#fff",
            pointHighlightStroke: "rgba(151,187,205,1)",
           data: [@foreach(var user in Model) {@Html.DisplayFor(u=>user.steps)}] 
        }
    ]
};


    var ctx = document.getElementById("chart").getContext("2d");
    window.myNewChart = new Chart(ctx).Line(chartData, {
        showTooltip: true,
        tooltipTemplate: "<%= value %>"
    });
</script>