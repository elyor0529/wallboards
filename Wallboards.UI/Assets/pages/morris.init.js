
var MorrisCharts = function () { };

//creates line chart
MorrisCharts.prototype.createLineChart = function (element, data, xkey, ykeys, labels, opacity, Pfillcolor, Pstockcolor, lineColors) {
    Morris.Line({
        element: element,
        data: data,
        xkey: xkey,
        ykeys: ykeys,
        labels: labels,
        fillOpacity: opacity,
        pointFillColors: Pfillcolor,
        pointStrokeColors: Pstockcolor,
        behaveLikeLine: true,
        gridLineColor: '#262c3b',
        hideHover: 'auto',
        resize: true, //defaulted to true
        lineColors: lineColors
    });
};

//creates area chart
MorrisCharts.prototype.createAreaChart = function (element, pointSize, lineWidth, data, xkey, ykeys, labels, lineColors) {
    Morris.Area({
        element: element,
        pointSize: 0,
        lineWidth: 0,
        data: data,
        xkey: xkey,
        ykeys: ykeys,
        labels: labels,
        hideHover: 'auto',
        resize: true,
        gridLineColor: '#262c3b',
        lineColors: lineColors
    });
};

//creates area chart with dotted
MorrisCharts.prototype.createAreaChartDotted = function (element, pointSize, lineWidth, data, xkey, ykeys, labels, Pfillcolor, Pstockcolor, lineColors) {
    Morris.Area({
        element: element,
        pointSize: 3,
        lineWidth: 1,
        data: data,
        xkey: xkey,
        ykeys: ykeys,
        labels: labels,
        hideHover: 'auto',
        pointFillColors: Pfillcolor,
        pointStrokeColors: Pstockcolor,
        resize: true,
        gridLineColor: '#262c3b',
        lineColors: lineColors
    });
};

//creates Bar chart
MorrisCharts.prototype.createBarChart = function (element, data, xkey, ykeys, labels, lineColors) {
    Morris.Bar({
        element: element,
        data: data,
        xkey: xkey,
        ykeys: ykeys,
        labels: labels,
        hideHover: 'always',
        resize: true, //defaulted to true
        gridLineColor: '#262c3b',
        barColors: lineColors
    });
};

//creates Stacked chart
MorrisCharts.prototype.createStackedChart = function (element, data, xkey, ykeys, labels, lineColors) {
    Morris.Bar({
        element: element,
        data: data,
        xkey: xkey,
        ykeys: ykeys,
        stacked: true,
        labels: labels,
        hideHover: 'auto',
        resize: true, //defaulted to true
        gridLineColor: '#262c3b',
        barColors: lineColors
    });
};

//creates Donut chart
MorrisCharts.prototype.createDonutChart = function (element, data, colors) {
    Morris.Donut({
        element: element,
        data: data,
        resize: true, //defaulted to true
        colors: colors,
        labelColor: '#fff'
    });
};

