//! Licensed to the .NET Foundation under one or more agreements.
//! The .NET Foundation licenses this file to you under the MIT license.

var e=!1;const t=async()=>WebAssembly.validate(new Uint8Array([0,97,115,109,1,0,0,0,1,4,1,96,0,0,3,2,1,0,10,8,1,6,0,6,64,25,11,11])),o=async()=>WebAssembly.validate(new Uint8Array([0,97,115,109,1,0,0,0,1,5,1,96,0,1,123,3,2,1,0,10,15,1,13,0,65,1,253,15,65,2,253,15,253,128,2,11])),n=async()=>WebAssembly.validate(new Uint8Array([0,97,115,109,1,0,0,0,1,5,1,96,0,1,123,3,2,1,0,10,10,1,8,0,65,0,253,15,253,98,11])),r=Symbol.for("wasm promise_control");function i(e,t){let o=null;const n=new Promise((function(n,r){o={isDone:!1,promise:null,resolve:t=>{o.isDone||(o.isDone=!0,n(t),e&&e())},reject:e=>{o.isDone||(o.isDone=!0,r(e),t&&t())}}}));o.promise=n;const i=n;return i[r]=o,{promise:i,promise_control:o}}function s(e){return e[r]}function a(e){e&&function(e){return void 0!==e[r]}(e)||Be(!1,"Promise is not controllable")}const l="__mono_message__",c=["debug","log","trace","warn","info","error"],d="MONO_WASM: ";let u,f,m,g,p,h;function w(e){g=e}function b(e){if(Pe.diagnosticTracing){const t="function"==typeof e?e():e;console.debug(d+t)}}function y(e,...t){console.info(d+e,...t)}function v(e,...t){console.info(e,...t)}function E(e,...t){console.warn(d+e,...t)}function _(e,...t){if(t&&t.length>0&&t[0]&&"object"==typeof t[0]){if(t[0].silent)return;if(t[0].toString)return void console.error(d+e,t[0].toString())}console.error(d+e,...t)}function x(e,t,o){return function(...n){try{let r=n[0];if(void 0===r)r="undefined";else if(null===r)r="null";else if("function"==typeof r)r=r.toString();else if("string"!=typeof r)try{r=JSON.stringify(r)}catch(e){r=r.toString()}t(o?JSON.stringify({method:e,payload:r,arguments:n.slice(1)}):[e+r,...n.slice(1)])}catch(e){m.error(`proxyConsole failed: ${e}`)}}}function j(e,t,o){f=t,g=e,m={...t};const n=`${o}/console`.replace("https://","wss://").replace("http://","ws://");u=new WebSocket(n),u.addEventListener("error",A),u.addEventListener("close",S),function(){for(const e of c)f[e]=x(`console.${e}`,T,!0)}()}function R(e){let t=30;const o=()=>{u?0==u.bufferedAmount||0==t?(e&&v(e),function(){for(const e of c)f[e]=x(`console.${e}`,m.log,!1)}(),u.removeEventListener("error",A),u.removeEventListener("close",S),u.close(1e3,e),u=void 0):(t--,globalThis.setTimeout(o,100)):e&&m&&m.log(e)};o()}function T(e){u&&u.readyState===WebSocket.OPEN?u.send(e):m.log(e)}function A(e){m.error(`[${g}] proxy console websocket error: ${e}`,e)}function S(e){m.debug(`[${g}] proxy console websocket closed: ${e}`,e)}function D(){Pe.preferredIcuAsset=O(Pe.config);let e="invariant"==Pe.config.globalizationMode;if(!e)if(Pe.preferredIcuAsset)Pe.diagnosticTracing&&b("ICU data archive(s) available, disabling invariant mode");else{if("custom"===Pe.config.globalizationMode||"all"===Pe.config.globalizationMode||"sharded"===Pe.config.globalizationMode){const e="invariant globalization mode is inactive and no ICU data archives are available";throw _(`ERROR: ${e}`),new Error(e)}Pe.diagnosticTracing&&b("ICU data archive(s) not available, using invariant globalization mode"),e=!0,Pe.preferredIcuAsset=null}const t="DOTNET_SYSTEM_GLOBALIZATION_INVARIANT",o=Pe.config.environmentVariables;if(void 0===o[t]&&e&&(o[t]="1"),void 0===o.TZ)try{const e=Intl.DateTimeFormat().resolvedOptions().timeZone||null;e&&(o.TZ=e)}catch(e){y("failed to detect timezone, will fallback to UTC")}}function O(e){var t;if((null===(t=e.resources)||void 0===t?void 0:t.icu)&&"invariant"!=e.globalizationMode){const t=e.applicationCulture||(ke?globalThis.navigator&&globalThis.navigator.languages&&globalThis.navigator.languages[0]:Intl.DateTimeFormat().resolvedOptions().locale),o=e.resources.icu;let n=null;if("custom"===e.globalizationMode){if(o.length>=1)return o[0].name}else t&&"all"!==e.globalizationMode?"sharded"===e.globalizationMode&&(n=function(e){const t=e.split("-")[0];return"en"===t||["fr","fr-FR","it","it-IT","de","de-DE","es","es-ES"].includes(e)?"icudt_EFIGS.dat":["zh","ko","ja"].includes(t)?"icudt_CJK.dat":"icudt_no_CJK.dat"}(t)):n="icudt.dat";if(n)for(let e=0;e<o.length;e++){const t=o[e];if(t.virtualPath===n)return t.name}}return e.globalizationMode="invariant",null}(new Date).valueOf();const C=class{constructor(e){this.url=e}toString(){return this.url}};async function k(e,t){try{const o="function"==typeof globalThis.fetch;if(Se){const n=e.startsWith("file://");if(!n&&o)return globalThis.fetch(e,t||{credentials:"same-origin"});p||(h=Ne.require("url"),p=Ne.require("fs")),n&&(e=h.fileURLToPath(e));const r=await p.promises.readFile(e);return{ok:!0,headers:{length:0,get:()=>null},url:e,arrayBuffer:()=>r,json:()=>JSON.parse(r),text:()=>{throw new Error("NotImplementedException")}}}if(o)return globalThis.fetch(e,t||{credentials:"same-origin"});if("function"==typeof read)return{ok:!0,url:e,headers:{length:0,get:()=>null},arrayBuffer:()=>new Uint8Array(read(e,"binary")),json:()=>JSON.parse(read(e,"utf8")),text:()=>read(e,"utf8")}}catch(t){return{ok:!1,url:e,status:500,headers:{length:0,get:()=>null},statusText:"ERR28: "+t,arrayBuffer:()=>{throw t},json:()=>{throw t},text:()=>{throw t}}}throw new Error("No fetch implementation available")}function I(e){return"string"!=typeof e&&Be(!1,"url must be a string"),!M(e)&&0!==e.indexOf("./")&&0!==e.indexOf("../")&&globalThis.URL&&globalThis.document&&globalThis.document.baseURI&&(e=new URL(e,globalThis.document.baseURI).toString()),e}const U=/^[a-zA-Z][a-zA-Z\d+\-.]*?:\/\//,P=/[a-zA-Z]:[\\/]/;function M(e){return Se||Ie?e.startsWith("/")||e.startsWith("\\")||-1!==e.indexOf("///")||P.test(e):U.test(e)}let L,N=0;const $=[],z=[],W=new Map,F={"js-module-threads":!0,"js-module-runtime":!0,"js-module-dotnet":!0,"js-module-native":!0,"js-module-diagnostics":!0},B={...F,"js-module-library-initializer":!0},V={...F,dotnetwasm:!0,heap:!0,manifest:!0},q={...B,manifest:!0},H={...B,dotnetwasm:!0},J={dotnetwasm:!0,symbols:!0},Z={...B,dotnetwasm:!0,symbols:!0},Q={symbols:!0};function G(e){return!("icu"==e.behavior&&e.name!=Pe.preferredIcuAsset)}function K(e,t,o){null!=t||(t=[]),Be(1==t.length,`Expect to have one ${o} asset in resources`);const n=t[0];return n.behavior=o,X(n),e.push(n),n}function X(e){V[e.behavior]&&W.set(e.behavior,e)}function Y(e){Be(V[e],`Unknown single asset behavior ${e}`);const t=W.get(e);if(t&&!t.resolvedUrl)if(t.resolvedUrl=Pe.locateFile(t.name),F[t.behavior]){const e=ge(t);e?("string"!=typeof e&&Be(!1,"loadBootResource response for 'dotnetjs' type should be a URL string"),t.resolvedUrl=e):t.resolvedUrl=ce(t.resolvedUrl,t.behavior)}else if("dotnetwasm"!==t.behavior)throw new Error(`Unknown single asset behavior ${e}`);return t}function ee(e){const t=Y(e);return Be(t,`Single asset for ${e} not found`),t}let te=!1;async function oe(){if(!te){te=!0,Pe.diagnosticTracing&&b("mono_download_assets");try{const e=[],t=[],o=(e,t)=>{!Z[e.behavior]&&G(e)&&Pe.expected_instantiated_assets_count++,!H[e.behavior]&&G(e)&&(Pe.expected_downloaded_assets_count++,t.push(se(e)))};for(const t of $)o(t,e);for(const e of z)o(e,t);Pe.allDownloadsQueued.promise_control.resolve(),Promise.all([...e,...t]).then((()=>{Pe.allDownloadsFinished.promise_control.resolve()})).catch((e=>{throw Pe.err("Error in mono_download_assets: "+e),Xe(1,e),e})),await Pe.runtimeModuleLoaded.promise;const n=async e=>{const t=await e;if(t.buffer){if(!Z[t.behavior]){t.buffer&&"object"==typeof t.buffer||Be(!1,"asset buffer must be array-like or buffer-like or promise of these"),"string"!=typeof t.resolvedUrl&&Be(!1,"resolvedUrl must be string");const e=t.resolvedUrl,o=await t.buffer,n=new Uint8Array(o);pe(t),await Ue.beforeOnRuntimeInitialized.promise,Ue.instantiate_asset(t,e,n)}}else J[t.behavior]?("symbols"===t.behavior&&(await Ue.instantiate_symbols_asset(t),pe(t)),J[t.behavior]&&++Pe.actual_downloaded_assets_count):(t.isOptional||Be(!1,"Expected asset to have the downloaded buffer"),!H[t.behavior]&&G(t)&&Pe.expected_downloaded_assets_count--,!Z[t.behavior]&&G(t)&&Pe.expected_instantiated_assets_count--)},r=[],i=[];for(const t of e)r.push(n(t));for(const e of t)i.push(n(e));Promise.all(r).then((()=>{Ce||Ue.coreAssetsInMemory.promise_control.resolve()})).catch((e=>{throw Pe.err("Error in mono_download_assets: "+e),Xe(1,e),e})),Promise.all(i).then((async()=>{Ce||(await Ue.coreAssetsInMemory.promise,Ue.allAssetsInMemory.promise_control.resolve())})).catch((e=>{throw Pe.err("Error in mono_download_assets: "+e),Xe(1,e),e}))}catch(e){throw Pe.err("Error in mono_download_assets: "+e),e}}}let ne=!1;function re(){if(ne)return;ne=!0;const e=Pe.config,t=[];if(e.assets)for(const t of e.assets)"object"!=typeof t&&Be(!1,`asset must be object, it was ${typeof t} : ${t}`),"string"!=typeof t.behavior&&Be(!1,"asset behavior must be known string"),"string"!=typeof t.name&&Be(!1,"asset name must be string"),t.resolvedUrl&&"string"!=typeof t.resolvedUrl&&Be(!1,"asset resolvedUrl could be string"),t.hash&&"string"!=typeof t.hash&&Be(!1,"asset resolvedUrl could be string"),t.pendingDownload&&"object"!=typeof t.pendingDownload&&Be(!1,"asset pendingDownload could be object"),t.isCore?$.push(t):z.push(t),X(t);else if(e.resources){const o=e.resources;o.wasmNative||Be(!1,"resources.wasmNative must be defined"),o.jsModuleNative||Be(!1,"resources.jsModuleNative must be defined"),o.jsModuleRuntime||Be(!1,"resources.jsModuleRuntime must be defined"),K(z,o.wasmNative,"dotnetwasm"),K(t,o.jsModuleNative,"js-module-native"),K(t,o.jsModuleRuntime,"js-module-runtime"),o.jsModuleDiagnostics&&K(t,o.jsModuleDiagnostics,"js-module-diagnostics");const n=(e,t,o)=>{const n=e;n.behavior=t,o?(n.isCore=!0,$.push(n)):z.push(n)};if(o.coreAssembly)for(let e=0;e<o.coreAssembly.length;e++)n(o.coreAssembly[e],"assembly",!0);if(o.assembly)for(let e=0;e<o.assembly.length;e++)n(o.assembly[e],"assembly",!o.coreAssembly);if(0!=e.debugLevel&&Pe.isDebuggingSupported()){if(o.corePdb)for(let e=0;e<o.corePdb.length;e++)n(o.corePdb[e],"pdb",!0);if(o.pdb)for(let e=0;e<o.pdb.length;e++)n(o.pdb[e],"pdb",!o.corePdb)}if(e.loadAllSatelliteResources&&o.satelliteResources)for(const e in o.satelliteResources)for(let t=0;t<o.satelliteResources[e].length;t++){const r=o.satelliteResources[e][t];r.culture=e,n(r,"resource",!o.coreAssembly)}if(o.coreVfs)for(let e=0;e<o.coreVfs.length;e++)n(o.coreVfs[e],"vfs",!0);if(o.vfs)for(let e=0;e<o.vfs.length;e++)n(o.vfs[e],"vfs",!o.coreVfs);const r=O(e);if(r&&o.icu)for(let e=0;e<o.icu.length;e++){const t=o.icu[e];t.name===r&&n(t,"icu",!1)}if(o.wasmSymbols)for(let e=0;e<o.wasmSymbols.length;e++)n(o.wasmSymbols[e],"symbols",!1)}if(e.appsettings)for(let t=0;t<e.appsettings.length;t++){const o=e.appsettings[t],n=he(o);"appsettings.json"!==n&&n!==`appsettings.${e.applicationEnvironment}.json`||z.push({name:o,behavior:"vfs",cache:"no-cache",useCredentials:!0})}e.assets=[...$,...z,...t]}async function ie(e){const t=await se(e);return await t.pendingDownloadInternal.response,t.buffer}async function se(e){try{return await ae(e)}catch(t){if(!Pe.enableDownloadRetry)throw t;if(Ie||Se)throw t;if(e.pendingDownload&&e.pendingDownloadInternal==e.pendingDownload)throw t;if(e.resolvedUrl&&-1!=e.resolvedUrl.indexOf("file://"))throw t;if(t&&404==t.status)throw t;e.pendingDownloadInternal=void 0,await Pe.allDownloadsQueued.promise;try{return Pe.diagnosticTracing&&b(`Retrying download '${e.name}'`),await ae(e)}catch(t){return e.pendingDownloadInternal=void 0,await new Promise((e=>globalThis.setTimeout(e,100))),Pe.diagnosticTracing&&b(`Retrying download (2) '${e.name}' after delay`),await ae(e)}}}async function ae(e){for(;L;)await L.promise;try{++N,N==Pe.maxParallelDownloads&&(Pe.diagnosticTracing&&b("Throttling further parallel downloads"),L=i());const t=await async function(e){if(e.pendingDownload&&(e.pendingDownloadInternal=e.pendingDownload),e.pendingDownloadInternal&&e.pendingDownloadInternal.response)return e.pendingDownloadInternal.response;if(e.buffer){const t=await e.buffer;return e.resolvedUrl||(e.resolvedUrl="undefined://"+e.name),e.pendingDownloadInternal={url:e.resolvedUrl,name:e.name,response:Promise.resolve({ok:!0,arrayBuffer:()=>t,json:()=>JSON.parse(new TextDecoder("utf-8").decode(t)),text:()=>{throw new Error("NotImplementedException")},headers:{get:()=>{}}})},e.pendingDownloadInternal.response}const t=e.loadRemote&&Pe.config.remoteSources?Pe.config.remoteSources:[""];let o;for(let n of t){n=n.trim(),"./"===n&&(n="");const t=le(e,n);e.name===t?Pe.diagnosticTracing&&b(`Attempting to download '${t}'`):Pe.diagnosticTracing&&b(`Attempting to download '${t}' for ${e.name}`);try{e.resolvedUrl=t;const n=fe(e);if(e.pendingDownloadInternal=n,o=await n.response,!o||!o.ok)continue;return o}catch(e){o||(o={ok:!1,url:t,status:0,statusText:""+e});continue}}const n=e.isOptional||e.name.match(/\.pdb$/)&&Pe.config.ignorePdbLoadErrors;if(o||Be(!1,`Response undefined ${e.name}`),!n){const t=new Error(`download '${o.url}' for ${e.name} failed ${o.status} ${o.statusText}`);throw t.status=o.status,t}y(`optional download '${o.url}' for ${e.name} failed ${o.status} ${o.statusText}`)}(e);return t?(J[e.behavior]||(e.buffer=await t.arrayBuffer(),++Pe.actual_downloaded_assets_count),e):e}finally{if(--N,L&&N==Pe.maxParallelDownloads-1){Pe.diagnosticTracing&&b("Resuming more parallel downloads");const e=L;L=void 0,e.promise_control.resolve()}}}function le(e,t){let o;return null==t&&Be(!1,`sourcePrefix must be provided for ${e.name}`),e.resolvedUrl?o=e.resolvedUrl:(o=""===t?"assembly"===e.behavior||"pdb"===e.behavior?e.name:"resource"===e.behavior&&e.culture&&""!==e.culture?`${e.culture}/${e.name}`:e.name:t+e.name,o=ce(Pe.locateFile(o),e.behavior)),o&&"string"==typeof o||Be(!1,"attemptUrl need to be path or url string"),o}function ce(e,t){return Pe.modulesUniqueQuery&&q[t]&&(e+=Pe.modulesUniqueQuery),e}let de=0;const ue=new Set;function fe(e){try{e.resolvedUrl||Be(!1,"Request's resolvedUrl must be set");const t=function(e){let t=e.resolvedUrl;if(Pe.loadBootResource){const o=ge(e);if(o instanceof Promise)return o;"string"==typeof o&&(t=o)}const o={};return e.cache?o.cache=e.cache:Pe.config.disableNoCacheFetch||(o.cache="no-cache"),e.useCredentials?o.credentials="include":!Pe.config.disableIntegrityCheck&&e.hash&&(o.integrity=e.hash),Pe.fetch_like(t,o)}(e),o={name:e.name,url:e.resolvedUrl,response:t};return ue.add(e.name),o.response.then((()=>{"assembly"==e.behavior&&Pe.loadedAssemblies.push(e.name),de++,Pe.onDownloadResourceProgress&&Pe.onDownloadResourceProgress(de,ue.size)})),o}catch(t){const o={ok:!1,url:e.resolvedUrl,status:500,statusText:"ERR29: "+t,arrayBuffer:()=>{throw t},json:()=>{throw t}};return{name:e.name,url:e.resolvedUrl,response:Promise.resolve(o)}}}const me={resource:"assembly",assembly:"assembly",pdb:"pdb",icu:"globalization",vfs:"configuration",manifest:"manifest",dotnetwasm:"dotnetwasm","js-module-dotnet":"dotnetjs","js-module-native":"dotnetjs","js-module-runtime":"dotnetjs","js-module-threads":"dotnetjs"};function ge(e){var t;if(Pe.loadBootResource){const o=null!==(t=e.hash)&&void 0!==t?t:"",n=e.resolvedUrl,r=me[e.behavior];if(r){const t=Pe.loadBootResource(r,e.name,n,o,e.behavior);return"string"==typeof t?I(t):t}}}function pe(e){e.pendingDownloadInternal=null,e.pendingDownload=null,e.buffer=null,e.moduleExports=null}function he(e){let t=e.lastIndexOf("/");return t>=0&&t++,e.substring(t)}async function we(e){e&&await Promise.all((null!=e?e:[]).map((e=>async function(e){try{const t=e.name;if(!e.moduleExports){const o=ce(Pe.locateFile(t),"js-module-library-initializer");Pe.diagnosticTracing&&b(`Attempting to import '${o}' for ${e}`),e.moduleExports=await import(/*! webpackIgnore: true */o)}Pe.libraryInitializers.push({scriptName:t,exports:e.moduleExports})}catch(t){E(`Failed to import library initializer '${e}': ${t}`)}}(e))))}async function be(e,t){if(!Pe.libraryInitializers)return;const o=[];for(let n=0;n<Pe.libraryInitializers.length;n++){const r=Pe.libraryInitializers[n];r.exports[e]&&o.push(ye(r.scriptName,e,(()=>r.exports[e](...t))))}await Promise.all(o)}async function ye(e,t,o){try{await o()}catch(o){throw E(`Failed to invoke '${t}' on library initializer '${e}': ${o}`),Xe(1,o),o}}function ve(e,t){if(e===t)return e;const o={...t};return void 0!==o.assets&&o.assets!==e.assets&&(o.assets=[...e.assets||[],...o.assets||[]]),void 0!==o.resources&&(o.resources=_e(e.resources||{assembly:[],jsModuleNative:[],jsModuleRuntime:[],wasmNative:[]},o.resources)),void 0!==o.environmentVariables&&(o.environmentVariables={...e.environmentVariables||{},...o.environmentVariables||{}}),void 0!==o.runtimeOptions&&o.runtimeOptions!==e.runtimeOptions&&(o.runtimeOptions=[...e.runtimeOptions||[],...o.runtimeOptions||[]]),Object.assign(e,o)}function Ee(e,t){if(e===t)return e;const o={...t};return o.config&&(e.config||(e.config={}),o.config=ve(e.config,o.config)),Object.assign(e,o)}function _e(e,t){if(e===t)return e;const o={...t};return void 0!==o.coreAssembly&&(o.coreAssembly=[...e.coreAssembly||[],...o.coreAssembly||[]]),void 0!==o.assembly&&(o.assembly=[...e.assembly||[],...o.assembly||[]]),void 0!==o.lazyAssembly&&(o.lazyAssembly=[...e.lazyAssembly||[],...o.lazyAssembly||[]]),void 0!==o.corePdb&&(o.corePdb=[...e.corePdb||[],...o.corePdb||[]]),void 0!==o.pdb&&(o.pdb=[...e.pdb||[],...o.pdb||[]]),void 0!==o.jsModuleWorker&&(o.jsModuleWorker=[...e.jsModuleWorker||[],...o.jsModuleWorker||[]]),void 0!==o.jsModuleNative&&(o.jsModuleNative=[...e.jsModuleNative||[],...o.jsModuleNative||[]]),void 0!==o.jsModuleDiagnostics&&(o.jsModuleDiagnostics=[...e.jsModuleDiagnostics||[],...o.jsModuleDiagnostics||[]]),void 0!==o.jsModuleRuntime&&(o.jsModuleRuntime=[...e.jsModuleRuntime||[],...o.jsModuleRuntime||[]]),void 0!==o.wasmSymbols&&(o.wasmSymbols=[...e.wasmSymbols||[],...o.wasmSymbols||[]]),void 0!==o.wasmNative&&(o.wasmNative=[...e.wasmNative||[],...o.wasmNative||[]]),void 0!==o.icu&&(o.icu=[...e.icu||[],...o.icu||[]]),void 0!==o.satelliteResources&&(o.satelliteResources=function(e,t){if(e===t)return e;for(const o in t)e[o]=[...e[o]||[],...t[o]||[]];return e}(e.satelliteResources||{},o.satelliteResources||{})),void 0!==o.modulesAfterConfigLoaded&&(o.modulesAfterConfigLoaded=[...e.modulesAfterConfigLoaded||[],...o.modulesAfterConfigLoaded||[]]),void 0!==o.modulesAfterRuntimeReady&&(o.modulesAfterRuntimeReady=[...e.modulesAfterRuntimeReady||[],...o.modulesAfterRuntimeReady||[]]),void 0!==o.extensions&&(o.extensions={...e.extensions||{},...o.extensions||{}}),void 0!==o.vfs&&(o.vfs=[...e.vfs||[],...o.vfs||[]]),Object.assign(e,o)}function xe(){const e=Pe.config;if(e.environmentVariables=e.environmentVariables||{},e.runtimeOptions=e.runtimeOptions||[],e.resources=e.resources||{assembly:[],jsModuleNative:[],jsModuleWorker:[],jsModuleRuntime:[],wasmNative:[],vfs:[],satelliteResources:{}},e.assets){Pe.diagnosticTracing&&b("config.assets is deprecated, use config.resources instead");for(const t of e.assets){const o={};switch(t.behavior){case"assembly":o.assembly=[t];break;case"pdb":o.pdb=[t];break;case"resource":o.satelliteResources={},o.satelliteResources[t.culture]=[t];break;case"icu":o.icu=[t];break;case"symbols":o.wasmSymbols=[t];break;case"vfs":o.vfs=[t];break;case"dotnetwasm":o.wasmNative=[t];break;case"js-module-threads":o.jsModuleWorker=[t];break;case"js-module-runtime":o.jsModuleRuntime=[t];break;case"js-module-native":o.jsModuleNative=[t];break;case"js-module-diagnostics":o.jsModuleDiagnostics=[t];break;case"js-module-dotnet":break;default:throw new Error(`Unexpected behavior ${t.behavior} of asset ${t.name}`)}_e(e.resources,o)}}e.debugLevel,e.applicationEnvironment||(e.applicationEnvironment="Production"),e.applicationCulture&&(e.environmentVariables.LANG=`${e.applicationCulture}.UTF-8`),Ue.diagnosticTracing=Pe.diagnosticTracing=!!e.diagnosticTracing,Ue.waitForDebugger=e.waitForDebugger,Pe.maxParallelDownloads=e.maxParallelDownloads||Pe.maxParallelDownloads,Pe.enableDownloadRetry=void 0!==e.enableDownloadRetry?e.enableDownloadRetry:Pe.enableDownloadRetry}let je=!1;async function Re(e){var t;if(je)return void await Pe.afterConfigLoaded.promise;let o;try{if(e.configSrc||Pe.config&&0!==Object.keys(Pe.config).length&&(Pe.config.assets||Pe.config.resources)||(e.configSrc="dotnet.boot.js"),o=e.configSrc,je=!0,o&&(Pe.diagnosticTracing&&b("mono_wasm_load_config"),await async function(e){const t=e.configSrc,o=Pe.locateFile(t);let n=null;void 0!==Pe.loadBootResource&&(n=Pe.loadBootResource("manifest",t,o,"","manifest"));let r,i=null;if(n)if("string"==typeof n)n.includes(".json")?(i=await s(I(n)),r=await Ae(i)):r=(await import(I(n))).config;else{const e=await n;"function"==typeof e.json?(i=e,r=await Ae(i)):r=e.config}else o.includes(".json")?(i=await s(ce(o,"manifest")),r=await Ae(i)):r=(await import(ce(o,"manifest"))).config;function s(e){return Pe.fetch_like(e,{method:"GET",credentials:"include",cache:"no-cache"})}Pe.config.applicationEnvironment&&(r.applicationEnvironment=Pe.config.applicationEnvironment),ve(Pe.config,r)}(e)),xe(),await we(null===(t=Pe.config.resources)||void 0===t?void 0:t.modulesAfterConfigLoaded),await be("onRuntimeConfigLoaded",[Pe.config]),e.onConfigLoaded)try{await e.onConfigLoaded(Pe.config,Le),xe()}catch(e){throw _("onConfigLoaded() failed",e),e}xe(),Pe.afterConfigLoaded.promise_control.resolve(Pe.config)}catch(t){const n=`Failed to load config file ${o} ${t} ${null==t?void 0:t.stack}`;throw Pe.config=e.config=Object.assign(Pe.config,{message:n,error:t,isError:!0}),Xe(1,new Error(n)),t}}function Te(){return!!globalThis.navigator&&(Pe.isChromium||Pe.isFirefox)}async function Ae(e){const t=Pe.config,o=await e.json();t.applicationEnvironment||o.applicationEnvironment||(o.applicationEnvironment=e.headers.get("Blazor-Environment")||e.headers.get("DotNet-Environment")||void 0),o.environmentVariables||(o.environmentVariables={});const n=e.headers.get("DOTNET-MODIFIABLE-ASSEMBLIES");n&&(o.environmentVariables.DOTNET_MODIFIABLE_ASSEMBLIES=n);const r=e.headers.get("ASPNETCORE-BROWSER-TOOLS");return r&&(o.environmentVariables.__ASPNETCORE_BROWSER_TOOLS=r),o}"function"!=typeof importScripts||globalThis.onmessage||(globalThis.dotnetSidecar=!0);const Se="object"==typeof process&&"object"==typeof process.versions&&"string"==typeof process.versions.node,De="function"==typeof importScripts,Oe=De&&"undefined"!=typeof dotnetSidecar,Ce=De&&!Oe,ke="object"==typeof window||De&&!Se,Ie=!ke&&!Se;let Ue={},Pe={},Me={},Le={},Ne={},$e=!1;const ze={},We={config:ze},Fe={mono:{},binding:{},internal:Ne,module:We,loaderHelpers:Pe,runtimeHelpers:Ue,diagnosticHelpers:Me,api:Le};function Be(e,t){if(e)return;const o="Assert failed: "+("function"==typeof t?t():t),n=new Error(o);_(o,n),Ue.nativeAbort(n)}function Ve(){return void 0!==Pe.exitCode}function qe(){return Ue.runtimeReady&&!Ve()}function He(){Ve()&&Be(!1,`.NET runtime already exited with ${Pe.exitCode} ${Pe.exitReason}. You can use runtime.runMain() which doesn't exit the runtime.`),Ue.runtimeReady||Be(!1,".NET runtime didn't start yet. Please call dotnet.create() first.")}function Je(){ke&&(globalThis.addEventListener("unhandledrejection",et),globalThis.addEventListener("error",tt))}let Ze,Qe;function Ge(e){Qe&&Qe(e),Xe(e,Pe.exitReason)}function Ke(e){Ze&&Ze(e||Pe.exitReason),Xe(1,e||Pe.exitReason)}function Xe(t,o){var n,r;const i=o&&"object"==typeof o;t=i&&"number"==typeof o.status?o.status:void 0===t?-1:t;const s=i&&"string"==typeof o.message?o.message:""+o;(o=i?o:Ue.ExitStatus?function(e,t){const o=new Ue.ExitStatus(e);return o.message=t,o.toString=()=>t,o}(t,s):new Error("Exit with code "+t+" "+s)).status=t,o.message||(o.message=s);const a=""+(o.stack||(new Error).stack);try{Object.defineProperty(o,"stack",{get:()=>a})}catch(e){}const l=!!o.silent;if(o.silent=!0,Ve())Pe.diagnosticTracing&&b("mono_exit called after exit");else{try{We.onAbort==Ke&&(We.onAbort=Ze),We.onExit==Ge&&(We.onExit=Qe),ke&&(globalThis.removeEventListener("unhandledrejection",et),globalThis.removeEventListener("error",tt)),Ue.runtimeReady?(Ue.jiterpreter_dump_stats&&Ue.jiterpreter_dump_stats(!1),0===t&&(null===(n=Pe.config)||void 0===n?void 0:n.interopCleanupOnExit)&&Ue.forceDisposeProxies(!0,!0),e&&0!==t&&(null===(r=Pe.config)||void 0===r||r.dumpThreadsOnNonZeroExit)):(Pe.diagnosticTracing&&b(`abort_startup, reason: ${o}`),function(e){Pe.allDownloadsQueued.promise_control.reject(e),Pe.allDownloadsFinished.promise_control.reject(e),Pe.afterConfigLoaded.promise_control.reject(e),Pe.wasmCompilePromise.promise_control.reject(e),Pe.runtimeModuleLoaded.promise_control.reject(e),Ue.dotnetReady&&(Ue.dotnetReady.promise_control.reject(e),Ue.afterInstantiateWasm.promise_control.reject(e),Ue.beforePreInit.promise_control.reject(e),Ue.afterPreInit.promise_control.reject(e),Ue.afterPreRun.promise_control.reject(e),Ue.beforeOnRuntimeInitialized.promise_control.reject(e),Ue.afterOnRuntimeInitialized.promise_control.reject(e),Ue.afterPostRun.promise_control.reject(e))}(o))}catch(e){E("mono_exit A failed",e)}try{l||(function(e,t){if(0!==e&&t){const e=Ue.ExitStatus&&t instanceof Ue.ExitStatus?b:_;"string"==typeof t?e(t):(void 0===t.stack&&(t.stack=(new Error).stack+""),t.message?e(Ue.stringify_as_error_with_stack?Ue.stringify_as_error_with_stack(t.message+"\n"+t.stack):t.message+"\n"+t.stack):e(JSON.stringify(t)))}!Ce&&Pe.config&&(Pe.config.logExitCode?Pe.config.forwardConsoleLogsToWS?R("WASM EXIT "+e):v("WASM EXIT "+e):Pe.config.forwardConsoleLogsToWS&&R())}(t,o),function(e){if(ke&&!Ce&&Pe.config&&Pe.config.appendElementOnExit&&document){const t=document.createElement("label");t.id="tests_done",0!==e&&(t.style.background="red"),t.innerHTML=""+e,document.body.appendChild(t)}}(t))}catch(e){E("mono_exit B failed",e)}Pe.exitCode=t,Pe.exitReason||(Pe.exitReason=o),!Ce&&Ue.runtimeReady&&We.runtimeKeepalivePop()}if(Pe.config&&Pe.config.asyncFlushOnExit&&0===t)throw(async()=>{try{await async function(){try{const e=await import(/*! webpackIgnore: true */"process"),t=e=>new Promise(((t,o)=>{e.on("error",o),e.end("","utf8",t)})),o=t(e.stderr),n=t(e.stdout);let r;const i=new Promise((e=>{r=setTimeout((()=>e("timeout")),1e3)}));await Promise.race([Promise.all([n,o]),i]),clearTimeout(r)}catch(e){_(`flushing std* streams failed: ${e}`)}}()}finally{Ye(t,o)}})(),o;Ye(t,o)}function Ye(e,t){if(Ue.runtimeReady&&Ue.nativeExit)try{Ue.nativeExit(e)}catch(e){!Ue.ExitStatus||e instanceof Ue.ExitStatus||E("set_exit_code_and_quit_now failed: "+e.toString())}if(0!==e||!ke)throw Se&&Ne.process?Ne.process.exit(e):Ue.quit&&Ue.quit(e,t),t}function et(e){ot(e,e.reason,"rejection")}function tt(e){ot(e,e.error,"error")}function ot(e,t,o){e.preventDefault();try{t||(t=new Error("Unhandled "+o)),void 0===t.stack&&(t.stack=(new Error).stack),t.stack=t.stack+"",t.silent||(_("Unhandled error:",t),Xe(1,t))}catch(e){}}!function(e){if($e)throw new Error("Loader module already loaded");$e=!0,Ue=e.runtimeHelpers,Pe=e.loaderHelpers,Me=e.diagnosticHelpers,Le=e.api,Ne=e.internal,Object.assign(Le,{INTERNAL:Ne,invokeLibraryInitializers:be}),Object.assign(e.module,{config:ve(ze,{environmentVariables:{}})});const r={mono_wasm_bindings_is_ready:!1,config:e.module.config,diagnosticTracing:!1,nativeAbort:e=>{throw e||new Error("abort")},nativeExit:e=>{throw new Error("exit:"+e)}},l={gitHash:"44525024595742ebe09023abe709df51de65009b",config:e.module.config,diagnosticTracing:!1,maxParallelDownloads:16,enableDownloadRetry:!0,_loaded_files:[],loadedFiles:[],loadedAssemblies:[],libraryInitializers:[],workerNextNumber:1,actual_downloaded_assets_count:0,actual_instantiated_assets_count:0,expected_downloaded_assets_count:0,expected_instantiated_assets_count:0,afterConfigLoaded:i(),allDownloadsQueued:i(),allDownloadsFinished:i(),wasmCompilePromise:i(),runtimeModuleLoaded:i(),loadingWorkers:i(),is_exited:Ve,is_runtime_running:qe,assert_runtime_running:He,mono_exit:Xe,createPromiseController:i,getPromiseController:s,assertIsControllablePromise:a,mono_download_assets:oe,resolve_single_asset_path:ee,setup_proxy_console:j,set_thread_prefix:w,installUnhandledErrorHandler:Je,retrieve_asset_download:ie,invokeLibraryInitializers:be,isDebuggingSupported:Te,exceptions:t,simd:n,relaxedSimd:o};Object.assign(Ue,r),Object.assign(Pe,l)}(Fe);let nt,rt,it,st=!1,at=!1;async function lt(e){if(!at){if(at=!0,ke&&Pe.config.forwardConsoleLogsToWS&&void 0!==globalThis.WebSocket&&j("main",globalThis.console,globalThis.location.origin),We||Be(!1,"Null moduleConfig"),Pe.config||Be(!1,"Null moduleConfig.config"),"function"==typeof e){const t=e(Fe.api);if(t.ready)throw new Error("Module.ready couldn't be redefined.");Object.assign(We,t),Ee(We,t)}else{if("object"!=typeof e)throw new Error("Can't use moduleFactory callback of createDotnetRuntime function.");Ee(We,e)}await async function(e){if(Se){const e=await import(/*! webpackIgnore: true */"process"),t=14;if(e.versions.node.split(".")[0]<t)throw new Error(`NodeJS at '${e.execPath}' has too low version '${e.versions.node}', please use at least ${t}. See also https://aka.ms/dotnet-wasm-features`)}const t=/*! webpackIgnore: true */import.meta.url,o=t.indexOf("?");var n;if(o>0&&(Pe.modulesUniqueQuery=t.substring(o)),Pe.scriptUrl=t.replace(/\\/g,"/").replace(/[?#].*/,""),Pe.scriptDirectory=(n=Pe.scriptUrl).slice(0,n.lastIndexOf("/"))+"/",Pe.locateFile=e=>"URL"in globalThis&&globalThis.URL!==C?new URL(e,Pe.scriptDirectory).toString():M(e)?e:Pe.scriptDirectory+e,Pe.fetch_like=k,Pe.out=console.log,Pe.err=console.error,Pe.onDownloadResourceProgress=e.onDownloadResourceProgress,ke&&globalThis.navigator){const e=globalThis.navigator,t=e.userAgentData&&e.userAgentData.brands;t&&t.length>0?Pe.isChromium=t.some((e=>"Google Chrome"===e.brand||"Microsoft Edge"===e.brand||"Chromium"===e.brand)):e.userAgent&&(Pe.isChromium=e.userAgent.includes("Chrome"),Pe.isFirefox=e.userAgent.includes("Firefox"))}Ne.require=Se?await import(/*! webpackIgnore: true */"module").then((e=>e.createRequire(/*! webpackIgnore: true */import.meta.url))):Promise.resolve((()=>{throw new Error("require not supported")})),void 0===globalThis.URL&&(globalThis.URL=C)}(We)}}async function ct(e){return await lt(e),Ze=We.onAbort,Qe=We.onExit,We.onAbort=Ke,We.onExit=Ge,We.ENVIRONMENT_IS_PTHREAD?async function(){(function(){const e=new MessageChannel,t=e.port1,o=e.port2;t.addEventListener("message",(e=>{var n,r;n=JSON.parse(e.data.config),r=JSON.parse(e.data.monoThreadInfo),st?Pe.diagnosticTracing&&b("mono config already received"):(ve(Pe.config,n),Ue.monoThreadInfo=r,xe(),Pe.diagnosticTracing&&b("mono config received"),st=!0,Pe.afterConfigLoaded.promise_control.resolve(Pe.config),ke&&n.forwardConsoleLogsToWS&&void 0!==globalThis.WebSocket&&Pe.setup_proxy_console("worker-idle",console,globalThis.location.origin)),t.close(),o.close()}),{once:!0}),t.start(),self.postMessage({[l]:{monoCmd:"preload",port:o}},[o])})(),await Pe.afterConfigLoaded.promise,function(){const e=Pe.config;e.assets||Be(!1,"config.assets must be defined");for(const t of e.assets)X(t),Q[t.behavior]&&z.push(t)}(),setTimeout((async()=>{try{await oe()}catch(e){Xe(1,e)}}),0);const e=dt(),t=await Promise.all(e);return await ut(t),We}():async function(){var e;await Re(We),re();const t=dt();(async function(){try{const e=ee("dotnetwasm");await se(e),e&&e.pendingDownloadInternal&&e.pendingDownloadInternal.response||Be(!1,"Can't load dotnet.native.wasm");const t=await e.pendingDownloadInternal.response,o=t.headers&&t.headers.get?t.headers.get("Content-Type"):void 0;let n;if("function"==typeof WebAssembly.compileStreaming&&"application/wasm"===o)n=await WebAssembly.compileStreaming(t);else{ke&&"application/wasm"!==o&&E('WebAssembly resource does not have the expected content type "application/wasm", so falling back to slower ArrayBuffer instantiation.');const e=await t.arrayBuffer();Pe.diagnosticTracing&&b("instantiate_wasm_module buffered"),n=Ie?await Promise.resolve(new WebAssembly.Module(e)):await WebAssembly.compile(e)}e.pendingDownloadInternal=null,e.pendingDownload=null,e.buffer=null,e.moduleExports=null,Pe.wasmCompilePromise.promise_control.resolve(n)}catch(e){Pe.wasmCompilePromise.promise_control.reject(e)}})(),setTimeout((async()=>{try{D(),await oe()}catch(e){Xe(1,e)}}),0);const o=await Promise.all(t);return await ut(o),await Ue.dotnetReady.promise,await we(null===(e=Pe.config.resources)||void 0===e?void 0:e.modulesAfterRuntimeReady),await be("onRuntimeReady",[Fe.api]),Le}()}function dt(){const e=ee("js-module-runtime"),t=ee("js-module-native");if(nt&&rt)return[nt,rt,it];"object"==typeof e.moduleExports?nt=e.moduleExports:(Pe.diagnosticTracing&&b(`Attempting to import '${e.resolvedUrl}' for ${e.name}`),nt=import(/*! webpackIgnore: true */e.resolvedUrl)),"object"==typeof t.moduleExports?rt=t.moduleExports:(Pe.diagnosticTracing&&b(`Attempting to import '${t.resolvedUrl}' for ${t.name}`),rt=import(/*! webpackIgnore: true */t.resolvedUrl));const o=Y("js-module-diagnostics");return o&&("object"==typeof o.moduleExports?it=o.moduleExports:(Pe.diagnosticTracing&&b(`Attempting to import '${o.resolvedUrl}' for ${o.name}`),it=import(/*! webpackIgnore: true */o.resolvedUrl))),[nt,rt,it]}async function ut(e){const{initializeExports:t,initializeReplacements:o,configureRuntimeStartup:n,configureEmscriptenStartup:r,configureWorkerStartup:i,setRuntimeGlobals:s,passEmscriptenInternals:a}=e[0],{default:l}=e[1],c=e[2];s(Fe),t(Fe),c&&c.setRuntimeGlobals(Fe),await n(We),Pe.runtimeModuleLoaded.promise_control.resolve(),l((e=>(Object.assign(We,{ready:e.ready,__dotnet_runtime:{initializeReplacements:o,configureEmscriptenStartup:r,configureWorkerStartup:i,passEmscriptenInternals:a}}),We))).catch((e=>{if(e.message&&e.message.toLowerCase().includes("out of memory"))throw new Error(".NET runtime has failed to start, because too much memory was requested. Please decrease the memory by adjusting EmccMaximumHeapSize. See also https://aka.ms/dotnet-wasm-features");throw e}))}const ft=new class{withModuleConfig(e){try{return Ee(We,e),this}catch(e){throw Xe(1,e),e}}withOnConfigLoaded(e){try{return Ee(We,{onConfigLoaded:e}),this}catch(e){throw Xe(1,e),e}}withConsoleForwarding(){try{return ve(ze,{forwardConsoleLogsToWS:!0}),this}catch(e){throw Xe(1,e),e}}withExitOnUnhandledError(){try{return ve(ze,{exitOnUnhandledError:!0}),Je(),this}catch(e){throw Xe(1,e),e}}withAsyncFlushOnExit(){try{return ve(ze,{asyncFlushOnExit:!0}),this}catch(e){throw Xe(1,e),e}}withExitCodeLogging(){try{return ve(ze,{logExitCode:!0}),this}catch(e){throw Xe(1,e),e}}withElementOnExit(){try{return ve(ze,{appendElementOnExit:!0}),this}catch(e){throw Xe(1,e),e}}withInteropCleanupOnExit(){try{return ve(ze,{interopCleanupOnExit:!0}),this}catch(e){throw Xe(1,e),e}}withDumpThreadsOnNonZeroExit(){try{return ve(ze,{dumpThreadsOnNonZeroExit:!0}),this}catch(e){throw Xe(1,e),e}}withWaitingForDebugger(e){try{return ve(ze,{waitForDebugger:e}),this}catch(e){throw Xe(1,e),e}}withInterpreterPgo(e,t){try{return ve(ze,{interpreterPgo:e,interpreterPgoSaveDelay:t}),ze.runtimeOptions?ze.runtimeOptions.push("--interp-pgo-recording"):ze.runtimeOptions=["--interp-pgo-recording"],this}catch(e){throw Xe(1,e),e}}withConfig(e){try{return ve(ze,e),this}catch(e){throw Xe(1,e),e}}withConfigSrc(e){try{return e&&"string"==typeof e||Be(!1,"must be file path or URL"),Ee(We,{configSrc:e}),this}catch(e){throw Xe(1,e),e}}withVirtualWorkingDirectory(e){try{return e&&"string"==typeof e||Be(!1,"must be directory path"),ve(ze,{virtualWorkingDirectory:e}),this}catch(e){throw Xe(1,e),e}}withEnvironmentVariable(e,t){try{const o={};return o[e]=t,ve(ze,{environmentVariables:o}),this}catch(e){throw Xe(1,e),e}}withEnvironmentVariables(e){try{return e&&"object"==typeof e||Be(!1,"must be dictionary object"),ve(ze,{environmentVariables:e}),this}catch(e){throw Xe(1,e),e}}withDiagnosticTracing(e){try{return"boolean"!=typeof e&&Be(!1,"must be boolean"),ve(ze,{diagnosticTracing:e}),this}catch(e){throw Xe(1,e),e}}withDebugging(e){try{return null!=e&&"number"==typeof e||Be(!1,"must be number"),ve(ze,{debugLevel:e}),this}catch(e){throw Xe(1,e),e}}withApplicationArguments(...e){try{return e&&Array.isArray(e)||Be(!1,"must be array of strings"),ve(ze,{applicationArguments:e}),this}catch(e){throw Xe(1,e),e}}withRuntimeOptions(e){try{return e&&Array.isArray(e)||Be(!1,"must be array of strings"),ze.runtimeOptions?ze.runtimeOptions.push(...e):ze.runtimeOptions=e,this}catch(e){throw Xe(1,e),e}}withMainAssembly(e){try{return ve(ze,{mainAssemblyName:e}),this}catch(e){throw Xe(1,e),e}}withApplicationArgumentsFromQuery(){try{if(!globalThis.window)throw new Error("Missing window to the query parameters from");if(void 0===globalThis.URLSearchParams)throw new Error("URLSearchParams is supported");const e=new URLSearchParams(globalThis.window.location.search).getAll("arg");return this.withApplicationArguments(...e)}catch(e){throw Xe(1,e),e}}withApplicationEnvironment(e){try{return ve(ze,{applicationEnvironment:e}),this}catch(e){throw Xe(1,e),e}}withApplicationCulture(e){try{return ve(ze,{applicationCulture:e}),this}catch(e){throw Xe(1,e),e}}withResourceLoader(e){try{return Pe.loadBootResource=e,this}catch(e){throw Xe(1,e),e}}async download(){try{await async function(){lt(We),await Re(We),re(),D(),oe(),await Pe.allDownloadsFinished.promise}()}catch(e){throw Xe(1,e),e}}async create(){try{return this.instance||(this.instance=await async function(){return await ct(We),Fe.api}()),this.instance}catch(e){throw Xe(1,e),e}}async run(){try{return We.config||Be(!1,"Null moduleConfig.config"),this.instance||await this.create(),this.instance.runMainAndExit()}catch(e){throw Xe(1,e),e}}},mt=Xe,gt=ct;Ie||"function"==typeof globalThis.URL||Be(!1,"This browser/engine doesn't support URL API. Please use a modern version. See also https://aka.ms/dotnet-wasm-features"),"function"!=typeof globalThis.BigInt64Array&&Be(!1,"This browser/engine doesn't support BigInt64Array API. Please use a modern version. See also https://aka.ms/dotnet-wasm-features"),ft.withConfig(/*json-start*/{
  "mainAssemblyName": "SpawnDev.BlazorJS.PixiJS.Demo",
  "resources": {
    "hash": "sha256-qOM2p5vE+rOk5SP8NOeeWXXFo6WfTSN9tEJ6Jx92ul8=",
    "jsModuleNative": [
      {
        "name": "dotnet.native.wzbdpgas2e.js"
      }
    ],
    "jsModuleRuntime": [
      {
        "name": "dotnet.runtime.2tx45g8lli.js"
      }
    ],
    "wasmNative": [
      {
        "name": "dotnet.native.9ge2k4kud6.wasm",
        "integrity": "sha256-qZlqVQS1Zm5B8T3McYfotns8Tj56lasAkbgv2sdHRGM=",
        "cache": "force-cache"
      }
    ],
    "icu": [
      {
        "virtualPath": "icudt_CJK.dat",
        "name": "icudt_CJK.tjcz0u77k5.dat",
        "integrity": "sha256-SZLtQnRc0JkwqHab0VUVP7T3uBPSeYzxzDnpxPpUnHk=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "icudt_EFIGS.dat",
        "name": "icudt_EFIGS.tptq2av103.dat",
        "integrity": "sha256-8fItetYY8kQ0ww6oxwTLiT3oXlBwHKumbeP2pRF4yTc=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "icudt_no_CJK.dat",
        "name": "icudt_no_CJK.lfu7j35m59.dat",
        "integrity": "sha256-L7sV7NEYP37/Qr2FPCePo5cJqRgTXRwGHuwF5Q+0Nfs=",
        "cache": "force-cache"
      }
    ],
    "coreAssembly": [
      {
        "virtualPath": "System.Runtime.InteropServices.JavaScript.wasm",
        "name": "System.Runtime.InteropServices.JavaScript.yzg2xf6fe9.wasm",
        "integrity": "sha256-jj+hXeHxXtNJ/yFTBFkWF83+YlrVlIlndehUiym2PoQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Private.CoreLib.wasm",
        "name": "System.Private.CoreLib.05nt5ahmgq.wasm",
        "integrity": "sha256-nMg+x7w5xxCg0l8mzYFZ0ZnxPAIGxqPRI5lLJLwnKBY=",
        "cache": "force-cache"
      }
    ],
    "assembly": [
      {
        "virtualPath": "BlazorMonaco.wasm",
        "name": "BlazorMonaco.i33mlyw1st.wasm",
        "integrity": "sha256-LvYzL5DdU2cB0aD0vdq7fb6O1CcuZvp3OxCq/HCckhk=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Humanizer.wasm",
        "name": "Humanizer.oqup3v7t3k.wasm",
        "integrity": "sha256-4NbSboZzzP9nikRtXapUZNzOyITt7ht9TNqCIQHr5OE=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "MetadataReferenceService.Abstractions.wasm",
        "name": "MetadataReferenceService.Abstractions.eqtypjjwrh.wasm",
        "integrity": "sha256-+h/37r9JiTjnuE8tb9TAeET1XFrQ5CEvwrBcCBh+4Ms=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "MetadataReferenceService.BlazorWasm.wasm",
        "name": "MetadataReferenceService.BlazorWasm.2kqvpono6y.wasm",
        "integrity": "sha256-zt7aCA9NvVLv08Au4CIp0WXRQOhOnAh8LRVGa4dD6iM=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.AspNetCore.Components.wasm",
        "name": "Microsoft.AspNetCore.Components.7o1w5a2h1g.wasm",
        "integrity": "sha256-iUIt27U2R6yf5wQTr6DezepTwMwu1raetfm8bDHanXI=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.AspNetCore.Components.Forms.wasm",
        "name": "Microsoft.AspNetCore.Components.Forms.v3o2h0zy2e.wasm",
        "integrity": "sha256-i0fDGae6s3IC5l50m2690/WWRyMuxI9Irembe6fyOKI=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.AspNetCore.Components.Web.wasm",
        "name": "Microsoft.AspNetCore.Components.Web.to2ca2r7c0.wasm",
        "integrity": "sha256-Y2XL4k7c6ZSA0rbtr9GgbVGwk93eAM1agFE++DEtZUI=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.AspNetCore.Components.WebAssembly.wasm",
        "name": "Microsoft.AspNetCore.Components.WebAssembly.0dx2syajxf.wasm",
        "integrity": "sha256-ZNkrnQWVE6YvZjXLQE7ORGymAd5Ip7Z+lXtUMbU5w6I=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.AspNetCore.Razor.Language.wasm",
        "name": "Microsoft.AspNetCore.Razor.Language.uqrgtxgez9.wasm",
        "integrity": "sha256-ii5+n5k0Wk/ZeHDvqLAYMYgKdjEjZfilGQXHiHQEF4U=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.CodeAnalysis.AnalyzerUtilities.wasm",
        "name": "Microsoft.CodeAnalysis.AnalyzerUtilities.f8evldgxkg.wasm",
        "integrity": "sha256-zyIWbIZkbJV6ViB6EkQZa+4z2LfSHfeLgRcZE1ofai0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.CodeAnalysis.wasm",
        "name": "Microsoft.CodeAnalysis.nengdb534m.wasm",
        "integrity": "sha256-fyOAAyK04RIyW5d7DAitGL8vGCVjHaOIqSwT6ky0UyE=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.CodeAnalysis.CSharp.wasm",
        "name": "Microsoft.CodeAnalysis.CSharp.a1bysepoeb.wasm",
        "integrity": "sha256-XpDDedMtm2o0cWGRWG3DMtmu05hkAi0wsTsHwrE3tqQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.CodeAnalysis.CSharp.Features.wasm",
        "name": "Microsoft.CodeAnalysis.CSharp.Features.l12cl527qp.wasm",
        "integrity": "sha256-pyFY5bQl8Fz//5nb0a30Gv9cgJeVE4gsKmEBZE7u6WE=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.CodeAnalysis.CSharp.Workspaces.wasm",
        "name": "Microsoft.CodeAnalysis.CSharp.Workspaces.c054ijf4nv.wasm",
        "integrity": "sha256-XGBYYfr1WNh2q1k9DdUAKLes+yLBwl53+eJT3Co+wAs=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.CodeAnalysis.Elfie.wasm",
        "name": "Microsoft.CodeAnalysis.Elfie.6dt0yknqsb.wasm",
        "integrity": "sha256-VkmO4woyJqa7TDcQ9e+kuZEdNoHkFA3Nd/d9RXWVxa0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.CodeAnalysis.Features.wasm",
        "name": "Microsoft.CodeAnalysis.Features.xwf7wknj71.wasm",
        "integrity": "sha256-UWzygIXIEBFrDQXQ5o3w21M8heygP4qRJC0swuRHUjA=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.CodeAnalysis.Razor.wasm",
        "name": "Microsoft.CodeAnalysis.Razor.md0dr3a2yd.wasm",
        "integrity": "sha256-1rWZ59QQXPb+po9nzp2oANQoGriyujFqz98Enf6le+Q=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.CodeAnalysis.Scripting.wasm",
        "name": "Microsoft.CodeAnalysis.Scripting.fdq0bm6jow.wasm",
        "integrity": "sha256-fVeK2t8UjVbQ+mkW8/QCr4gUY9DkJJNhph8S8tOBzJk=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.CodeAnalysis.Workspaces.wasm",
        "name": "Microsoft.CodeAnalysis.Workspaces.sxdfetxi1a.wasm",
        "integrity": "sha256-sBkfwqlMHk/Y1V8+EL01863NJRWDJZZKiMnfVNWCql4=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.DiaSymReader.wasm",
        "name": "Microsoft.DiaSymReader.n7aozp74g0.wasm",
        "integrity": "sha256-s8A+LIZPdelFgqksm2voS6oVrorJuL2xM+/mgQHThnM=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Configuration.wasm",
        "name": "Microsoft.Extensions.Configuration.b5r9igf1ej.wasm",
        "integrity": "sha256-UUwnFUGVKcfnwTDp5d2PPIYvZb3p3cZn9VEABGLlYu8=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Configuration.Abstractions.wasm",
        "name": "Microsoft.Extensions.Configuration.Abstractions.9hvqdnyedj.wasm",
        "integrity": "sha256-I1V6RT2jU36RMO/udOCdtpwqRuricdlZ0IRsQvGrIKQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Configuration.Json.wasm",
        "name": "Microsoft.Extensions.Configuration.Json.pc68mejkzb.wasm",
        "integrity": "sha256-1y+HiAKbF6OQQk1mMwcqiDmk9C6LrRUGiP4uFK0Kwk8=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.DependencyInjection.wasm",
        "name": "Microsoft.Extensions.DependencyInjection.0xo10c3s43.wasm",
        "integrity": "sha256-nOuSVOF7MdaYpoSuozvVXBeUJWC3OVLBOW/eCFsJCZo=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.DependencyInjection.Abstractions.wasm",
        "name": "Microsoft.Extensions.DependencyInjection.Abstractions.pw8s9mldn5.wasm",
        "integrity": "sha256-GW01EFPHTuFHCJevOSUhB+gG0XYmEDUP3OoeoA66HNM=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Logging.wasm",
        "name": "Microsoft.Extensions.Logging.zh7psstrkj.wasm",
        "integrity": "sha256-Nw6fMz9mMm8SS3pPrUsobEC9zzLKC6AKDJhHRldk9VA=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Logging.Abstractions.wasm",
        "name": "Microsoft.Extensions.Logging.Abstractions.1kdc1oztmi.wasm",
        "integrity": "sha256-X78TdTgU/3Pd3qeRvD+qNMFWjhbxTXjduw5WXDir0JY=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Options.wasm",
        "name": "Microsoft.Extensions.Options.q0isp0bwe9.wasm",
        "integrity": "sha256-xkyLAPfxZLG3DS2pYTOo1wsrUQw1das0A4L94HzZ43Q=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Extensions.Primitives.wasm",
        "name": "Microsoft.Extensions.Primitives.vga3bvc9pt.wasm",
        "integrity": "sha256-QeF3pj2LH3LcaB6cg9nSyYQ6/Pf6RbTkLakVnAwVPXo=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.JSInterop.wasm",
        "name": "Microsoft.JSInterop.rnehoh7dg2.wasm",
        "integrity": "sha256-ie8clNNKgKni4e/2voYwcQrICKYEsQWY6jTBh5yC0sU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.JSInterop.WebAssembly.wasm",
        "name": "Microsoft.JSInterop.WebAssembly.nsfh695mwg.wasm",
        "integrity": "sha256-N8RKL2Eil4ZFxIkWa6Uig12+nRHOstda562q7GCs9fE=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Radzen.Blazor.wasm",
        "name": "Radzen.Blazor.s02nlybk1j.wasm",
        "integrity": "sha256-/BYkVozDzBwuQS2tRnP3CzSonGPCX5nV00eAvHpYQKQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "SpawnDev.BackgroundServices.wasm",
        "name": "SpawnDev.BackgroundServices.o55nwjvr9o.wasm",
        "integrity": "sha256-JIo07sg6BjmGo8tGfICUCjqpfyRiEA+YYo91XWcnEGY=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "SpawnDev.BlazorJS.wasm",
        "name": "SpawnDev.BlazorJS.wwko1dt93f.wasm",
        "integrity": "sha256-4ITJ+7XcLBVs+/Vcf9g+jGcOHkmXC8EjuiNg9d+FxJI=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "SpawnDev.BlazorJS.CodeRunner.wasm",
        "name": "SpawnDev.BlazorJS.CodeRunner.ek8igsbipo.wasm",
        "integrity": "sha256-ItSv13+uRJCzq4aPgQkJ4dPVcFNhUACRdkrdBEx5C30=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Stef.Validation.wasm",
        "name": "Stef.Validation.o546fwiwr0.wasm",
        "integrity": "sha256-jGlbjRzesmEbKvxgsEnwtrhp83fvkAfqzdvle7SaP+M=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Composition.AttributedModel.wasm",
        "name": "System.Composition.AttributedModel.7wlzo97gc2.wasm",
        "integrity": "sha256-l6XhhWoUeMZoTJp9Pds5+OySvD5Pe7uqOOjbfoEQLBg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Composition.Convention.wasm",
        "name": "System.Composition.Convention.rz18ai2loe.wasm",
        "integrity": "sha256-F+4ut/DaW2Av6QU6SdGriyNzMj2p4JzzR2reZCMdptQ=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Composition.Hosting.wasm",
        "name": "System.Composition.Hosting.ryf802n5m2.wasm",
        "integrity": "sha256-0/qasPu6Qo58V4uI3GtAfSeXqIEYm7qkOxsn7RqPx0k=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Composition.Runtime.wasm",
        "name": "System.Composition.Runtime.95w5ugnd1o.wasm",
        "integrity": "sha256-AwDMfJHvw82zEJSArg/LEaeS/NwYibPFbBNJov+W0SE=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Composition.TypedParts.wasm",
        "name": "System.Composition.TypedParts.az7zj6fkp3.wasm",
        "integrity": "sha256-Js6jMny7OmkVoorhI/erhg5kvJQNMXkRvsbp8kzVBmg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Configuration.ConfigurationManager.wasm",
        "name": "System.Configuration.ConfigurationManager.50p01uimie.wasm",
        "integrity": "sha256-awi0DdRMBQr2w3YJtU9l+nQSH2MH5AsDPHbXPa4qWO8=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Diagnostics.EventLog.wasm",
        "name": "System.Diagnostics.EventLog.r8r83x8oi4.wasm",
        "integrity": "sha256-FT09aAHl9Pr4fpKSFTYUltt0EmahXb+zoKoalbSMVG4=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Security.Cryptography.ProtectedData.wasm",
        "name": "System.Security.Cryptography.ProtectedData.2yj0iaqwy3.wasm",
        "integrity": "sha256-BkHqtpEGgmL8T3LHQ3xBXuG30aVtho8kecNryUecI4k=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.CSharp.wasm",
        "name": "Microsoft.CSharp.qqns9amlgw.wasm",
        "integrity": "sha256-zueDTcOHqjaoZKB+YjFq8xITXV+ZG6425gwq2wkeSsw=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "Microsoft.Win32.Primitives.wasm",
        "name": "Microsoft.Win32.Primitives.fbk3pdgpuy.wasm",
        "integrity": "sha256-m9bILeHTRpNlGNvV+Hs49WCqiGJEPXVhq7t94/BVVwI=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Collections.Concurrent.wasm",
        "name": "System.Collections.Concurrent.jpsmtndd3m.wasm",
        "integrity": "sha256-Kbz7NhG/02TDvMaU2rSj8EsK1ciknntSQFFtR6VWQFY=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Collections.Immutable.wasm",
        "name": "System.Collections.Immutable.whjd61pems.wasm",
        "integrity": "sha256-DOLrITQukgOwy6BthRufyhCRtRgwsTTD7o/bzE8o7zU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Collections.NonGeneric.wasm",
        "name": "System.Collections.NonGeneric.67fwb92pq8.wasm",
        "integrity": "sha256-8iPdb1wOwSlBbqa/TkE5VhCHHs9E4xmDSMbMvFs+pgc=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Collections.Specialized.wasm",
        "name": "System.Collections.Specialized.ndu6kq927s.wasm",
        "integrity": "sha256-Sytl0XJmrhBfQMYKkCMsuX9UryHzg8UJ0R+EjRvH7kA=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Collections.wasm",
        "name": "System.Collections.oizb70ehmj.wasm",
        "integrity": "sha256-cPDcQgwOFu/YwBoRrrk4fGiaMUmHlSV//xcU1t9YLNk=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.ComponentModel.Annotations.wasm",
        "name": "System.ComponentModel.Annotations.4upw5vwu2f.wasm",
        "integrity": "sha256-NDRDFKlpVgCmWVFWbVTmm29Nzs3Xdr4Sx/+mui22Dqk=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.ComponentModel.Primitives.wasm",
        "name": "System.ComponentModel.Primitives.g5iufmie1z.wasm",
        "integrity": "sha256-ZN6TgiQUwgQnLawlJK/upUkIFDhEGuZvzeN6lGz3BUU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.ComponentModel.TypeConverter.wasm",
        "name": "System.ComponentModel.TypeConverter.1ew2zrn4ux.wasm",
        "integrity": "sha256-ec93m1DKP+hwPGXu7+ce92Z9VzJrc10lRAfjcUBIUbc=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.ComponentModel.wasm",
        "name": "System.ComponentModel.f26bvh4l3r.wasm",
        "integrity": "sha256-d9a92/neOPg1jZOp/Y355QzupmnFOwLdIP3wYSshwZs=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Console.wasm",
        "name": "System.Console.931zymw5ge.wasm",
        "integrity": "sha256-u1WE2SSHulz7KZzmOaRbOT58pvz97NGZqJnE2bH6bEU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Core.wasm",
        "name": "System.Core.mszblqghkw.wasm",
        "integrity": "sha256-ClkRunIKwPDnYS7DtqeoRFyo/qZYK1qcdDs/LQyVngU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Data.Common.wasm",
        "name": "System.Data.Common.kjrqkonnpv.wasm",
        "integrity": "sha256-8DEaDroX8Lxi47zERVJ+44KDb5vU10993WLTH9qJmHk=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Data.DataSetExtensions.wasm",
        "name": "System.Data.DataSetExtensions.o4j7fnd6e9.wasm",
        "integrity": "sha256-mNdVET/x1RhPAqid86RWK7fT+6ie+CcM0nhxRF4h988=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Diagnostics.DiagnosticSource.wasm",
        "name": "System.Diagnostics.DiagnosticSource.yb70lppe2a.wasm",
        "integrity": "sha256-4pFxQ2YmLmeNTav63LvYDfmNaAWMXFxHmYQ2S+udfxU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Diagnostics.FileVersionInfo.wasm",
        "name": "System.Diagnostics.FileVersionInfo.1xkjkrxrxq.wasm",
        "integrity": "sha256-paD4f8WsNsVSdA3eJSuH0OVa+fCtrA2xRjdM48K6/FE=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Diagnostics.Process.wasm",
        "name": "System.Diagnostics.Process.3vr6ibmpk6.wasm",
        "integrity": "sha256-j9ByTE8KlQEAqj0UV5mps81zoXOPqUXamhxm+W1Ou64=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Diagnostics.StackTrace.wasm",
        "name": "System.Diagnostics.StackTrace.d1bskwvqw2.wasm",
        "integrity": "sha256-4arWFLDBFB5L6+7eBQbAdBjYv81c7FP9nBtFeL/bguw=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Diagnostics.TextWriterTraceListener.wasm",
        "name": "System.Diagnostics.TextWriterTraceListener.pq60qoa7bb.wasm",
        "integrity": "sha256-38OUKH2sJCr24WapenLYE/lUgUD0em21H/+tDrW0CPk=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Diagnostics.TraceSource.wasm",
        "name": "System.Diagnostics.TraceSource.7g1vxvpbjo.wasm",
        "integrity": "sha256-6fmZaRwJLayhMiJ4LLKI28UrG0hGZ1ZJ7SPxaTsrAfs=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Diagnostics.Tracing.wasm",
        "name": "System.Diagnostics.Tracing.2lvn3un22t.wasm",
        "integrity": "sha256-pgo6hDMDyM5JOQYN8WuNu2UBYL+Vl/HRMbSrbook+wo=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Drawing.Primitives.wasm",
        "name": "System.Drawing.Primitives.xhkwm166db.wasm",
        "integrity": "sha256-xYl+klCpZxUOShdaByTfB9SUN52ad9QwSceu6rXRdVg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Drawing.wasm",
        "name": "System.Drawing.sfv6afh671.wasm",
        "integrity": "sha256-WKUq/8/T1LPe2Fyy4LLvvyl4FHtt6T7zCREMzthqeDs=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Globalization.wasm",
        "name": "System.Globalization.4ahc8d1dax.wasm",
        "integrity": "sha256-hHFpvRnrz0KVDXuB3CucF6BhGGx8k4AwCVXbPFubPIU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.Compression.wasm",
        "name": "System.IO.Compression.jxnm40d73t.wasm",
        "integrity": "sha256-WclaTDe2wCe6P80FwGCOt9uPvMoa/6ffQoWfiHoINWk=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.MemoryMappedFiles.wasm",
        "name": "System.IO.MemoryMappedFiles.qgltlir0mr.wasm",
        "integrity": "sha256-6n5XxvQ/4nNueQ6ckaMGo6bCgVGDdMhl6BFkG9u5Wes=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.IO.Pipelines.wasm",
        "name": "System.IO.Pipelines.23mjs38mxf.wasm",
        "integrity": "sha256-jn56t1s7iyUJNXjt5Zo6Wm9n3wzIT6R6g5vtBODjxAA=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Linq.Expressions.wasm",
        "name": "System.Linq.Expressions.32nt0qd0zm.wasm",
        "integrity": "sha256-BW634Ehr3n+al8UUcVRdfV7VVQJAUHBqfifFhbUb10Q=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Linq.Queryable.wasm",
        "name": "System.Linq.Queryable.0my7lmgu33.wasm",
        "integrity": "sha256-+HdFvS348OpUIiDDMHjGnRaYctRdYVgjL2Ufz29RagM=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Linq.wasm",
        "name": "System.Linq.y7seoa64eu.wasm",
        "integrity": "sha256-XmYVUgOShBsJ0kJaJkeqsvG170WWmOHqD44GRpfGM7s=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Memory.wasm",
        "name": "System.Memory.fog5j1skec.wasm",
        "integrity": "sha256-UcVJamvU0VvXpseoB8vYvdjXBmFMTv0NEklcI4BMoWw=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.Http.Json.wasm",
        "name": "System.Net.Http.Json.3r89uy2aag.wasm",
        "integrity": "sha256-cSUoHZG14YSbZK0pq1ZsPdAYSdJP7gP3nRCa3WGlzy8=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.Http.wasm",
        "name": "System.Net.Http.9zwnqtlx6l.wasm",
        "integrity": "sha256-tYTMsHi5//QS+tBMqd2TgZRgryim3EevKcHIY0uLp0Y=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.Primitives.wasm",
        "name": "System.Net.Primitives.nzksdwz72n.wasm",
        "integrity": "sha256-Q/b2CEUoSBgfB/H1e1m7bWS9CcWJ6N3h8oMhXIkXsAU=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.Requests.wasm",
        "name": "System.Net.Requests.tk4garpi7n.wasm",
        "integrity": "sha256-LSH3uRtiFDZzcLcQTAJXDO2rfwk5wHvHvZGxU3WA6PI=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Net.WebClient.wasm",
        "name": "System.Net.WebClient.lpy9dzel5r.wasm",
        "integrity": "sha256-By/oFO2E7krBy9CX/V/gmBuaNej8IzW7max53OcRm5o=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.ObjectModel.wasm",
        "name": "System.ObjectModel.c8jbp7v18b.wasm",
        "integrity": "sha256-HJvIg7MVBEpRkzm/NFbtKPJ1dD0A29L/iKzOCdAoxUo=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Private.DataContractSerialization.wasm",
        "name": "System.Private.DataContractSerialization.5qbpr8ot3p.wasm",
        "integrity": "sha256-neLYEaT5gDxvW9+UwopGRCKdOT3rBXuwsKLe+U8If1Y=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Private.Uri.wasm",
        "name": "System.Private.Uri.zf62k94wgw.wasm",
        "integrity": "sha256-4dq5GikPqTSIfjPyyumdyXWUJLcvUBpxDn1YO5RoqYs=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Private.Xml.Linq.wasm",
        "name": "System.Private.Xml.Linq.h9pqnmdwcb.wasm",
        "integrity": "sha256-ZWEukXtVPJAjzOPocbBI76Ar6ujod0Dn2JlClIe+huk=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Private.Xml.wasm",
        "name": "System.Private.Xml.vjsccjh48r.wasm",
        "integrity": "sha256-i+Mjg++INeZHpOGuP1O5ZlLNb2PNgEc6gIHMhjSag8A=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Reflection.Metadata.wasm",
        "name": "System.Reflection.Metadata.z5z3rlwhut.wasm",
        "integrity": "sha256-x4MsCXuXJFVPB6tScPmvq6bC/0bYL9JtZy4KaQaL7ig=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Reflection.Primitives.wasm",
        "name": "System.Reflection.Primitives.hqiia9qdp1.wasm",
        "integrity": "sha256-WR1LZkbvb3tGyhatNsT3G9tRemHQOzlXPhcaRNmLmck=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.InteropServices.wasm",
        "name": "System.Runtime.InteropServices.ow1e9kgoav.wasm",
        "integrity": "sha256-KHpyAqQXL/ZAnATB1qqdmYd3IS83qN7dzr/AbZm8ww0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.Intrinsics.wasm",
        "name": "System.Runtime.Intrinsics.j9vypni9ii.wasm",
        "integrity": "sha256-OVjoJ+Fvw82Nn9IX10YlXvhMgWMI5f1W1a/v7a+2bd0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.Loader.wasm",
        "name": "System.Runtime.Loader.zssb0qqjqr.wasm",
        "integrity": "sha256-bZH2dxNSbGifJkXqxIaNJ/Lxgi4fGHcHCuY1oUvY7Rc=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.Numerics.wasm",
        "name": "System.Runtime.Numerics.6ioqx6ul21.wasm",
        "integrity": "sha256-ckgqKt3FBN6VOTTiWv37k6zAYoWpVZQjUT48aBlFnCo=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.Serialization.Formatters.wasm",
        "name": "System.Runtime.Serialization.Formatters.hoov2xnqhh.wasm",
        "integrity": "sha256-seQqI0DwhLkDDV8AsSueqS/Ap+dF1BwfIlryagMEEaA=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.Serialization.Json.wasm",
        "name": "System.Runtime.Serialization.Json.tj38eu2ghn.wasm",
        "integrity": "sha256-BxYFOQ3IgxfPuMDpv0IZ964L3Ipb87muoj6DXon0ULw=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.Serialization.Primitives.wasm",
        "name": "System.Runtime.Serialization.Primitives.5qurn8mjw1.wasm",
        "integrity": "sha256-TYsUgIn0QmQ275yHp4jxbeSctcHoA1g0oLp8Uc1SHdI=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.Serialization.Xml.wasm",
        "name": "System.Runtime.Serialization.Xml.firwz1rx5i.wasm",
        "integrity": "sha256-uRVDD7NVNAaxr0w8PFQncWsK4Z6XGwdlXuIaoRgJyOs=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Runtime.wasm",
        "name": "System.Runtime.qmnmrmn9nh.wasm",
        "integrity": "sha256-3hsckrG194PEPLjrq6uM1Jxri4/iJmFrhzGYnQfrkdA=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Security.Cryptography.wasm",
        "name": "System.Security.Cryptography.4m87ax6bfi.wasm",
        "integrity": "sha256-XLUC9JCfPFA+ewFl7wuotHWVD6i+eKaamPfnKZiLSVg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Security.Principal.Windows.wasm",
        "name": "System.Security.Principal.Windows.o3t1t0ql5a.wasm",
        "integrity": "sha256-lGYYk/Qn3nITjNt2/QWrm42v+2ZRvLHUvj+usS/DuOw=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Text.Encoding.CodePages.wasm",
        "name": "System.Text.Encoding.CodePages.4rmojd4pn3.wasm",
        "integrity": "sha256-MFAGVSRd8OUGUeyQIIK5x2hweppc5S9yplfUd1TtbLw=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Text.Encoding.Extensions.wasm",
        "name": "System.Text.Encoding.Extensions.bxcvrssgkb.wasm",
        "integrity": "sha256-L/5dee+TqIFApzN+80xpPbtb4kbNZluny5iBEPJdS4I=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Text.Encodings.Web.wasm",
        "name": "System.Text.Encodings.Web.5h7q1pbb0u.wasm",
        "integrity": "sha256-p0I/gu1hfXiqySJ0vHMhSHtvZJzEZT0WOYNWq4peun0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Text.Json.wasm",
        "name": "System.Text.Json.5ocelw2rlz.wasm",
        "integrity": "sha256-WzNHmqKFNuCpdnxy3/QuA6twl04kagzRF4tY1dvVO/4=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Text.RegularExpressions.wasm",
        "name": "System.Text.RegularExpressions.ydu1v0do5i.wasm",
        "integrity": "sha256-Fp+iz2Am6O0wlVmE8yIQte9d31xQO66lXkdVhXFYlmc=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Threading.Channels.wasm",
        "name": "System.Threading.Channels.o7pp5bmapx.wasm",
        "integrity": "sha256-HKOxk2pUrRKPSyec1RqorUzX+6DuS/oaldPAT1cSP9Q=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Threading.Tasks.Parallel.wasm",
        "name": "System.Threading.Tasks.Parallel.iaak7k86ms.wasm",
        "integrity": "sha256-Gqiq7lN8FNYoEXiNSi57SvozEBF0b/FsEFXZ4FzZHs0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Threading.Thread.wasm",
        "name": "System.Threading.Thread.94v20jm063.wasm",
        "integrity": "sha256-CZbpUIhrIWw7jX4WkICW0Eg+1t6MH6ZbGnayeCn+aZg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Threading.ThreadPool.wasm",
        "name": "System.Threading.ThreadPool.250f3guh07.wasm",
        "integrity": "sha256-ig78HLXJRKvLite5ZDuhBginMXJI5RzVKAiFABE9J3s=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Threading.wasm",
        "name": "System.Threading.dgussn545b.wasm",
        "integrity": "sha256-LTE8mrBUBy55Hfo5CSEzN94JvoMeNZgDpAqQiGkPm2c=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Web.HttpUtility.wasm",
        "name": "System.Web.HttpUtility.yumtzsmcbl.wasm",
        "integrity": "sha256-+muVPHyhkGEH9ij+c3lNpsRaeWjSJwTo4UEdHAUEns0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Xml.Linq.wasm",
        "name": "System.Xml.Linq.bno46imr5t.wasm",
        "integrity": "sha256-x8MB2DkAOXhOCsJ/AzpobuVUqt727s2bp6fDdDQ1d8A=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Xml.ReaderWriter.wasm",
        "name": "System.Xml.ReaderWriter.suaendqd88.wasm",
        "integrity": "sha256-jCbFveGXg/eJi0zf4AvfE6jIiagfUqI43lzhmQiw+Vg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Xml.XDocument.wasm",
        "name": "System.Xml.XDocument.iaismzcosm.wasm",
        "integrity": "sha256-ZrKEdfRhIO6IHjtcsJEJvy4dkvnXQNRNgjMdqdiUJlg=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Xml.XPath.XDocument.wasm",
        "name": "System.Xml.XPath.XDocument.n8gvgyrsc3.wasm",
        "integrity": "sha256-9+tXAQojlaMIPnxd5U2b5WKR7cWW3UakF054vHDnt/s=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Xml.XPath.wasm",
        "name": "System.Xml.XPath.waw0iunch7.wasm",
        "integrity": "sha256-iJ0/sSlQstg39csOZS3By1EP+ZDovpxDTuf1nU3b2Cc=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.Xml.XmlSerializer.wasm",
        "name": "System.Xml.XmlSerializer.lg3doxxggo.wasm",
        "integrity": "sha256-O2F7Z1LahLS3+mgPUYCHzGYng5LRVczp4PSQNzoxRs0=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "System.wasm",
        "name": "System.l9jolnojrw.wasm",
        "integrity": "sha256-d1dcH2nxptL8QLqZqtRI5G+lrjrbUKrUOnC/yloVB98=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "netstandard.wasm",
        "name": "netstandard.t3fq58zg9a.wasm",
        "integrity": "sha256-B7yzimeUAKjWpdVnFGHUg8vJogiaaW4d7qLIaJdXs84=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "SpawnDev.BlazorJS.PixiJS.wasm",
        "name": "SpawnDev.BlazorJS.PixiJS.oagfyc62sf.wasm",
        "integrity": "sha256-wA1vLSIV5XDJuZ9/TE8MEW+RwJCzWj7pq9vOnmSulaI=",
        "cache": "force-cache"
      },
      {
        "virtualPath": "SpawnDev.BlazorJS.PixiJS.Demo.wasm",
        "name": "SpawnDev.BlazorJS.PixiJS.Demo.zng6nuocy5.wasm",
        "integrity": "sha256-38j78A43Ko4dg3egJyckMD+G3ObPbcml4L+USahuOJQ=",
        "cache": "force-cache"
      }
    ],
    "satelliteResources": {
      "cs": [
        {
          "virtualPath": "Microsoft.CodeAnalysis.resources.wasm",
          "name": "Microsoft.CodeAnalysis.resources.3f11h443mn.wasm",
          "integrity": "sha256-b/7XxkfdQ08OLv+bGbaiBhtckqJRI5klL8/nncYheGg=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.resources.bwa3i3el2o.wasm",
          "integrity": "sha256-67c/UzwYh2hjSKX+n4AFCIId25i+Vgu+jbFF9piMjBA=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Features.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.Features.resources.48baujzfdi.wasm",
          "integrity": "sha256-rK6TtXJ0K9DwjZQD+OVVwWxpUJDop05MgcBx0snTnGs=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.k54a6h8ezd.wasm",
          "integrity": "sha256-iN1M9M9tmGY8RBrEP2uAmMlNDQzW2TroZRVN1ZehwDg=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Features.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Features.resources.kw7bk4jdaf.wasm",
          "integrity": "sha256-xJBgn8pNLhksUaRSIrIgCF0RpI5NWfwZxJsX8L3KpMw=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Scripting.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Scripting.resources.zvl6471bxl.wasm",
          "integrity": "sha256-sXuZIpmdpuO6A/GEGrFyQU4VcLB8MDWpfWSUAZldUfQ=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Workspaces.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Workspaces.resources.ctl2nxqpkf.wasm",
          "integrity": "sha256-EKp1lni8maa7UbP3PL28tcyy4jYhpAK0khwW670QQFc=",
          "cache": "force-cache"
        }
      ],
      "de": [
        {
          "virtualPath": "Microsoft.CodeAnalysis.resources.wasm",
          "name": "Microsoft.CodeAnalysis.resources.ap9ajtkngn.wasm",
          "integrity": "sha256-ntYTLDIZmxZVhIwt4Qacp+XwfxvbwBVHuQZz4fJH9fc=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.resources.hcs5545l9p.wasm",
          "integrity": "sha256-P5zdPfZZJxSpeIHRIp0hR6ogffVPJ3VOGR9GQ+DgQZU=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Features.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.Features.resources.622pwqf4o9.wasm",
          "integrity": "sha256-UnE+SiKJ1e6tPH50lCFX1VUJLC0smA/31wB+qB1EZk8=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.ybzodtnrcd.wasm",
          "integrity": "sha256-IkYhQLd1zRmprjNdGbVBp5Qnwp17MhdzLb2tn2nWVvE=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Features.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Features.resources.7ea047ipb9.wasm",
          "integrity": "sha256-n5QTO9K3pP8KrUWhelmlKblg6BA40B0GvXitpxgXsI0=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Scripting.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Scripting.resources.eqmes0lnjb.wasm",
          "integrity": "sha256-lhYbwK8/GzslxrHXTtuK8A9LPtQzCUR+Irrlkgs30KM=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Workspaces.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Workspaces.resources.6vlv098rpa.wasm",
          "integrity": "sha256-coQAHs7G1HAE7e5U5AaTrAcq1po65J386ozU66WRgxU=",
          "cache": "force-cache"
        }
      ],
      "es": [
        {
          "virtualPath": "Microsoft.CodeAnalysis.resources.wasm",
          "name": "Microsoft.CodeAnalysis.resources.48zifsf0c8.wasm",
          "integrity": "sha256-1NEFHzoH/0xmnA+AQjoZKUp7MJDQqk/McmSsffXEPqg=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.resources.eqarcv9wzs.wasm",
          "integrity": "sha256-FmcDploG5XZRDBhtz/PtZkjAR4fi/W+wuDS/SoGYZXA=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Features.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.Features.resources.1v06eqz28n.wasm",
          "integrity": "sha256-3W+v/mwY5GhOd+s2/bHH05Dd7E8/jwvyi7bP+1rsZoY=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.ysue2w58cb.wasm",
          "integrity": "sha256-jlpIMHZJsrmrcIUQY57HcuXfD53UFdQIDxBWe2Q/lh4=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Features.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Features.resources.wq64h1a14q.wasm",
          "integrity": "sha256-KDDSLvsDiWw1SvKHOMGYLPc0JWwv+QrxvgeHA2AyF3Y=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Scripting.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Scripting.resources.688ca50a5m.wasm",
          "integrity": "sha256-prI5ivlj4shtPdJjS4E7teP8pH8N7aw7c0CXxw9d884=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Workspaces.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Workspaces.resources.iu9ya8x0df.wasm",
          "integrity": "sha256-ph94beLu5TWnJ4h/528nZYh4u8TXt2tzIflndY2xVoU=",
          "cache": "force-cache"
        }
      ],
      "fr": [
        {
          "virtualPath": "Microsoft.CodeAnalysis.resources.wasm",
          "name": "Microsoft.CodeAnalysis.resources.43s49o8vcc.wasm",
          "integrity": "sha256-MLA3cK3HVboFUsAhVrXtY8KbxYNVI+OkegTzjUKad/4=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.resources.f11zfzrp25.wasm",
          "integrity": "sha256-A7s+aywHEjsFG7n7AbRVOkqTVSH/8NCQZbpnh7nXYBg=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Features.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.Features.resources.u5da1s6lgz.wasm",
          "integrity": "sha256-IpIssEC88q8dMyHmax86V5gbiDJtzXymI5/RfaoDKYQ=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.mjr46r66xz.wasm",
          "integrity": "sha256-jqkmpyr610L/Mmdgm63RFTr/Jv8FYpiWU2HkRRQod6E=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Features.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Features.resources.ky5bwp6yhw.wasm",
          "integrity": "sha256-7PYVu3j0VIBHJDwJdYcsn20uejCJ4Z9CdD+y3CxcHl4=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Scripting.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Scripting.resources.zn4ttrn37h.wasm",
          "integrity": "sha256-IYqUPjraERCeP9hAUNezh5B4+9jthziBDIha7jMczUs=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Workspaces.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Workspaces.resources.s7onx47u0d.wasm",
          "integrity": "sha256-WBuCSA/shL057/jKYmGf77+CkP7sR72TKARSO4PLah4=",
          "cache": "force-cache"
        }
      ],
      "it": [
        {
          "virtualPath": "Microsoft.CodeAnalysis.resources.wasm",
          "name": "Microsoft.CodeAnalysis.resources.ddqifi0hfp.wasm",
          "integrity": "sha256-AY0CyOrf2IAvqVsZS+RlHlDNxurOD6eGLkYTX781xFY=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.resources.5z7ioh6tw8.wasm",
          "integrity": "sha256-H2tP+dTbwIG8P1HhS8LGqr32lsrbxtx/KpIRYdm8DWk=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Features.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.Features.resources.r1ngby6tfp.wasm",
          "integrity": "sha256-UdTlsW2e8cbGKGJ/VOEjphk+yKbG9/gOG5MYmZx22cc=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.plg0ydrefe.wasm",
          "integrity": "sha256-DTpnOGEHdSVQBPbWBPD1rqYp8PbY9AYv/tdHz+mzeHU=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Features.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Features.resources.621q85hzsi.wasm",
          "integrity": "sha256-ImzkKstqS5jcENKn4spmmFrk/9iIwKZBPKKQMwikYX4=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Scripting.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Scripting.resources.yglxh8m4uw.wasm",
          "integrity": "sha256-DuQ8hQG9vzjoplAWrWjA43yuY4fTdowC0ZlI83238AY=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Workspaces.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Workspaces.resources.kutlctg85u.wasm",
          "integrity": "sha256-pFW4LSHYo0H3aX/416+0TtEKB2QSSKXIAP/ONRv/4ho=",
          "cache": "force-cache"
        }
      ],
      "ja": [
        {
          "virtualPath": "Microsoft.CodeAnalysis.resources.wasm",
          "name": "Microsoft.CodeAnalysis.resources.jzwbennsh8.wasm",
          "integrity": "sha256-QYrhVpbSDCD27u+vZi6rzo2GK4d7CydxvS2feZasauI=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.resources.n53iejw3bq.wasm",
          "integrity": "sha256-e5q9cuCQ1nRfHF/soDrKFf2x1w3q1n9XfIS0XSyCKNw=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Features.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.Features.resources.dzjrtmd5mg.wasm",
          "integrity": "sha256-F/35Xu1x+dXYUmbbClSGpW0JMnwqZ93+twzCyu+WtEU=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.78ihxt8t9x.wasm",
          "integrity": "sha256-h4uRw23S369raModSAI72Dw+oTzLxUgGXMp5HR+H2eI=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Features.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Features.resources.4tz6je7dzs.wasm",
          "integrity": "sha256-OGqJ/s5HniS8jdD4cu1zQ6fV1+I7erTnVbQfUZheEC8=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Scripting.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Scripting.resources.hdyalipave.wasm",
          "integrity": "sha256-e2ZAkDTr2jum86yJ8Y6GnwzsA8j7veUNuAIv0N+O6NY=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Workspaces.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Workspaces.resources.aq9if3pqbt.wasm",
          "integrity": "sha256-wmxnSfJrfekNo6CB7Auf6ACQQF/RbrtmBjqpI5Ge2c4=",
          "cache": "force-cache"
        }
      ],
      "ko": [
        {
          "virtualPath": "Microsoft.CodeAnalysis.resources.wasm",
          "name": "Microsoft.CodeAnalysis.resources.d70ppdglmf.wasm",
          "integrity": "sha256-SRob2sZYevNK3LLg5ZLxEOme7As2g4gPlHS+ZyCa7QY=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.resources.s6otrkychu.wasm",
          "integrity": "sha256-TPWt+E1I9lWP8Nx0DkAsi6COw82CPyTjoPd8SnVzPmQ=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Features.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.Features.resources.dfaj3lxl9v.wasm",
          "integrity": "sha256-d51Ug28pQIyzi0FRcM9D0FZ67lUGyhKpATMT1Wp1wTM=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.6o4o01liez.wasm",
          "integrity": "sha256-Wl5dsnI1g0u1GgtBaY0IJOSaTZS0khGHarPMkPHQ1Y4=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Features.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Features.resources.ks8ko2h65l.wasm",
          "integrity": "sha256-hFnJotlGMZB4NUPYYhlw7egd2w6kVPw4CnvI2XFHhCY=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Scripting.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Scripting.resources.g3hvhp50kn.wasm",
          "integrity": "sha256-tJJgmEuT8a/eIJtsw84bG5mVVZZbKrCF00vAyeTZ1oI=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Workspaces.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Workspaces.resources.lstt25actf.wasm",
          "integrity": "sha256-6613sQOb82ewmQ40RatBa66y1bQ4svhoziXMutr0nOs=",
          "cache": "force-cache"
        }
      ],
      "pl": [
        {
          "virtualPath": "Microsoft.CodeAnalysis.resources.wasm",
          "name": "Microsoft.CodeAnalysis.resources.njyyw78ehe.wasm",
          "integrity": "sha256-nYCf+HDAs5qbZ13ZP11cOgdOTww9CMn52Z84Hy3Mq6Y=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.resources.fnkoia6zcp.wasm",
          "integrity": "sha256-i1jWO8qZtbVtQAelMC45FNG/v4ccnOtUk+9+CRUH/Go=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Features.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.Features.resources.8m0lbkk6p1.wasm",
          "integrity": "sha256-oI6CMcdfUiT2h6wBz/6DzyEANsGuL8HoTmkqVFdXSV4=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.qwtr286899.wasm",
          "integrity": "sha256-KpIVfhbtsLoPxvBrsVwxlBMa1fWKUbU3Pnl3vPJSYEI=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Features.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Features.resources.yu22qzwh3h.wasm",
          "integrity": "sha256-Bn+EngXi6vqVgEK3T9KrQc84rC6cm5RfJ/u8Ce5kP4c=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Scripting.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Scripting.resources.fsn0osr6tv.wasm",
          "integrity": "sha256-kU8JtIYNtyTOzkDnWQCxT2t1xnXPgOXzac3Typf1Qzs=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Workspaces.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Workspaces.resources.o9owgy3jzg.wasm",
          "integrity": "sha256-3AoKwy20GoYgZmOynglWTfn2Clr+GPfB60DWcdnYHi0=",
          "cache": "force-cache"
        }
      ],
      "pt-BR": [
        {
          "virtualPath": "Microsoft.CodeAnalysis.resources.wasm",
          "name": "Microsoft.CodeAnalysis.resources.wtreoaptyp.wasm",
          "integrity": "sha256-nCvYa7U+DXzGNdhbgutHiftoSth4arfQXJGJXmG3d60=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.resources.s3xzujbenq.wasm",
          "integrity": "sha256-WMyQ50jRm/xirabZHTCxtaLpiqlHzPrFg+AEptMOmi8=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Features.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.Features.resources.85wo6zpt5m.wasm",
          "integrity": "sha256-vLriUiZJJ8IaFl1FeZUr/HTgCo41hpuCZSE1MtDGFHY=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.28uaihu6kh.wasm",
          "integrity": "sha256-gk0LDQ889EM51Jggyv+BY+NFQP2JCeyuGbD9oi9/pDs=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Features.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Features.resources.l6bzod54bk.wasm",
          "integrity": "sha256-Xd8J5XP1su0hvHQDpl7/OtKaicTtZUtEvnR8Zwoc+20=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Scripting.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Scripting.resources.fesj99q8ox.wasm",
          "integrity": "sha256-hyNqZ4CzrLR+RC57KJLk52ZeI0P+TXIvVn31JTxNzpk=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Workspaces.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Workspaces.resources.adeyocs6iu.wasm",
          "integrity": "sha256-wnp7xU7jZ36rYf0b19aXq6B1pkJBxv1IRIe+kZUKUR0=",
          "cache": "force-cache"
        }
      ],
      "ru": [
        {
          "virtualPath": "Microsoft.CodeAnalysis.resources.wasm",
          "name": "Microsoft.CodeAnalysis.resources.0sjyxlfhb0.wasm",
          "integrity": "sha256-oP2UHAx4bPEKHb0ZsS1kLb5Gj9PpkFIpsrX4zIQ27+w=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.resources.oj2etcgoc2.wasm",
          "integrity": "sha256-nA6k+Nq6BaKo4OtRcylFFVZClJv5boB5YRfMt+Xee+8=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Features.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.Features.resources.3s020f8951.wasm",
          "integrity": "sha256-jTONAoY4tdySosEDnKeCGGy0x6hBywX+dnPIcYWTKfQ=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.2kfai8ip7e.wasm",
          "integrity": "sha256-vsATELz6LoXeCZs/EgMCytHkoI4LQxeqccsiGm7nE8o=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Features.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Features.resources.z1gpl8qjpk.wasm",
          "integrity": "sha256-eS1/n3Dp6FWs/sK1zHbMN3eUncC8+FJ6AoPbDPDhF0M=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Scripting.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Scripting.resources.jlvpu9hv8z.wasm",
          "integrity": "sha256-ySFfJSwqC7v61wRqHbgCX38SYoqOjIdSQqYXA3R+0iM=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Workspaces.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Workspaces.resources.x08texaskn.wasm",
          "integrity": "sha256-4V+wotCUWNFmMDo13Ml0D6gxfJIhmFfdRlkFTthjL28=",
          "cache": "force-cache"
        }
      ],
      "tr": [
        {
          "virtualPath": "Microsoft.CodeAnalysis.resources.wasm",
          "name": "Microsoft.CodeAnalysis.resources.544biwp7jg.wasm",
          "integrity": "sha256-lQtp3G0/gsAB7QRBVRx6V0ScHH6/ghfzi9sWqD49GG0=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.resources.6w5szw7eti.wasm",
          "integrity": "sha256-KoCwM4/Q8VKjoPdLJ0vDwBA/VAa9G5yCSOi6xs1O8lU=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Features.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.Features.resources.a9oy5vzg3f.wasm",
          "integrity": "sha256-TuBk2Dq6WUEOvh8YL0+Gub+uVMrXcd2dphDfbeT0Xbs=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.8tsnnlq7ex.wasm",
          "integrity": "sha256-nDzrXTQ9D94OBw1pcm5n07Swq384WrDmvQHir+vYIac=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Features.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Features.resources.w6ovwpu91t.wasm",
          "integrity": "sha256-ONBNAtpuQxsyiKbGJZvLc0/SEKLSMauZme9qiSlIFfo=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Scripting.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Scripting.resources.hrsklt56n4.wasm",
          "integrity": "sha256-nWfFNYIa6382K22pfRr2I4IWebpoZuCGIiK0YKGo6Uo=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Workspaces.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Workspaces.resources.8drg4linoa.wasm",
          "integrity": "sha256-dDlHkjngPb3XHtHG9bXGkTY7XBDKS9rZjm1Wdsp3Fdw=",
          "cache": "force-cache"
        }
      ],
      "zh-Hans": [
        {
          "virtualPath": "Microsoft.CodeAnalysis.resources.wasm",
          "name": "Microsoft.CodeAnalysis.resources.6qo8mm3gye.wasm",
          "integrity": "sha256-0rJg9DbseFuM+Tk0p9gbrZ+AZzXbxXpxpy42TVJyhPA=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.resources.tnbynbg9xq.wasm",
          "integrity": "sha256-iTKVXsMJkPJigo+BHKqQs+9NXDZKbPOeT1fW9RV7SPg=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Features.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.Features.resources.trre1g7qqj.wasm",
          "integrity": "sha256-GVUA8J9FsOVCSGXQTe4Jke9YzurxJsa737q8zQ7FqWM=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.0ai4mkrkoe.wasm",
          "integrity": "sha256-iIvPY6cNiEIDeAKymg7o5U1mg28IwkH2Ipsnv1fuSxY=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Features.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Features.resources.ufxyybz5y9.wasm",
          "integrity": "sha256-NkQeRHkZHUzW75gTxdkoZFevhPPjKo+vT0fFPE2hCOI=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Scripting.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Scripting.resources.px4av62dkx.wasm",
          "integrity": "sha256-gxFvK6l9U7vfpt1Vm+KkgPyTOWjpOCM5ZkWGg36gbpI=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Workspaces.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Workspaces.resources.adlg4l659d.wasm",
          "integrity": "sha256-LmgAbpOiNbhuDOft6i23z76Vk3/4BEiETcOA/Pn9yAo=",
          "cache": "force-cache"
        }
      ],
      "zh-Hant": [
        {
          "virtualPath": "Microsoft.CodeAnalysis.resources.wasm",
          "name": "Microsoft.CodeAnalysis.resources.chzw27fnls.wasm",
          "integrity": "sha256-oOmz6gmDcOUzLREISA4eA2B9AZv8fE/u0A1zaI2qcBc=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.resources.bhujetjgiw.wasm",
          "integrity": "sha256-D7ONP11AlAB/JpqInLSahqS9dgvhu5XGdw0UDMA1yu0=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Features.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.Features.resources.rlnwe6m8zp.wasm",
          "integrity": "sha256-f0VyA7XHKewLDEAhhjZbe8w0NLOTudmbi9Z99zwih34=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.wasm",
          "name": "Microsoft.CodeAnalysis.CSharp.Workspaces.resources.p23qje88dx.wasm",
          "integrity": "sha256-Ef35nDKHDpt2InmKBOuMAYpHsxYx02b8RF7Fdc76bik=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Features.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Features.resources.z7p25v31ci.wasm",
          "integrity": "sha256-0aK01Nsx2wrgu8+4xmbqnXJo4hnjn0Ho8zDmJn3RqS4=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Scripting.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Scripting.resources.zjfgi137w4.wasm",
          "integrity": "sha256-v5gE2PKcwAgjFrHoYAqQtzxMOScmpza7qZj3uZ76SmQ=",
          "cache": "force-cache"
        },
        {
          "virtualPath": "Microsoft.CodeAnalysis.Workspaces.resources.wasm",
          "name": "Microsoft.CodeAnalysis.Workspaces.resources.x4vga8od5r.wasm",
          "integrity": "sha256-X9QaURkIiHODDD5OrxRqFVT9J2YCWixC7pugSiDpzFQ=",
          "cache": "force-cache"
        }
      ]
    },
    "libraryInitializers": [
      {
        "name": "SpawnDev.BlazorJS.lib.module.js"
      }
    ],
    "modulesAfterRuntimeReady": [
      {
        "name": "../SpawnDev.BlazorJS.lib.module.js"
      }
    ]
  },
  "debugLevel": 0,
  "linkerEnabled": true,
  "globalizationMode": "sharded",
  "extensions": {
    "blazor": {}
  },
  "runtimeConfig": {
    "runtimeOptions": {
      "configProperties": {
        "Microsoft.AspNetCore.Components.Routing.RegexConstraintSupport": false,
        "Microsoft.Extensions.DependencyInjection.VerifyOpenGenericServiceTrimmability": true,
        "System.ComponentModel.DefaultValueAttribute.IsSupported": false,
        "System.ComponentModel.Design.IDesignerHost.IsSupported": false,
        "System.ComponentModel.TypeConverter.EnableUnsafeBinaryFormatterInDesigntimeLicenseContextSerialization": false,
        "System.ComponentModel.TypeDescriptor.IsComObjectDescriptorSupported": false,
        "System.Data.DataSet.XmlSerializationIsSupported": false,
        "System.Diagnostics.Debugger.IsSupported": false,
        "System.Diagnostics.Metrics.Meter.IsSupported": false,
        "System.Diagnostics.Tracing.EventSource.IsSupported": false,
        "System.GC.Server": true,
        "System.Globalization.Invariant": false,
        "System.TimeZoneInfo.Invariant": false,
        "System.Linq.Enumerable.IsSizeOptimized": true,
        "System.Net.Http.EnableActivityPropagation": false,
        "System.Net.Http.WasmEnableStreamingResponse": true,
        "System.Net.SocketsHttpHandler.Http3Support": false,
        "System.Reflection.Metadata.MetadataUpdater.IsSupported": false,
        "System.Resources.ResourceManager.AllowCustomResourceTypes": false,
        "System.Resources.UseSystemResourceKeys": true,
        "System.Runtime.CompilerServices.RuntimeFeature.IsDynamicCodeSupported": true,
        "System.Runtime.InteropServices.BuiltInComInterop.IsSupported": false,
        "System.Runtime.InteropServices.EnableConsumingManagedCodeFromNativeHosting": false,
        "System.Runtime.InteropServices.EnableCppCLIHostActivation": false,
        "System.Runtime.InteropServices.Marshalling.EnableGeneratedComInterfaceComImportInterop": false,
        "System.Runtime.Serialization.EnableUnsafeBinaryFormatterSerialization": false,
        "System.StartupHookProvider.IsSupported": false,
        "System.Text.Encoding.EnableUnsafeUTF7Encoding": false,
        "System.Text.Json.JsonSerializer.IsReflectionEnabledByDefault": true,
        "System.Threading.Thread.EnableAutoreleasePool": false,
        "Microsoft.AspNetCore.Components.Endpoints.NavigationManager.DisableThrowNavigationException": false
      }
    }
  }
}/*json-end*/);export{gt as default,ft as dotnet,mt as exit};
