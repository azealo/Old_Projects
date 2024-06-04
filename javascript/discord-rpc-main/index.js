var rpc = require("discord-rpc")
const client = new rpc.Client({ transport: 'ipc' })
client.on('ready', () => {
client.request('SET_ACTIVITY', {
pid: process.pid,
activity : {
details : "The Rising King's Of Ğ",
assets : {
large_image : "gamma.png",
large_text : "napim" // bu gözükmeyebilir!!
},
buttons : [{label : "Minecraft" , url : "https://www.minecraft.net/tr-tr"},{label : "OptiFine",url : "https://optifine.net/home"}] //kendinize göre yazın
}
})
})
client.login({ clientId : "855465496211750962" }).catch(console.error);