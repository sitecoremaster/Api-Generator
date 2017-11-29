module.exports = function () {
    var sitecoreRoot = "C:\\Sitecore\\ApiGenerator";
    var config = {
        websiteRoot: sitecoreRoot + "\\Website",
        sitecoreLibraries: sitecoreRoot + "\\Website\\bin",
        solutionName: "ApiGenerator",
        licensePath: sitecoreRoot + "\\Data\\license.xml",
        runCleanBuilds: false
    };
    return config;
}