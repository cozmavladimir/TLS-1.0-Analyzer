﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3074
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Moserware.TlsAnalyzer.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ABABABABABABABABABABABABABABABAB ABABABABABABABABABABABABABABABAB ABABABABABABABA" +
            "BABABABABABABABAB")]
        public string PrfSecretBytes {
            get {
                return ((string)(this["PrfSecretBytes"]));
            }
            set {
                this["PrfSecretBytes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("PRF Testvector")]
        public string PrfLabel {
            get {
                return ((string)(this["PrfLabel"]));
            }
            set {
                this["PrfLabel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("CDCDCDCDCDCDCDCDCDCDCDCDCDCDCDCD CDCDCDCDCDCDCDCDCDCDCDCDCDCDCDCD CDCDCDCDCDCDCDC" +
            "DCDCDCDCDCDCDCDCD CDCDCDCDCDCDCDCDCDCDCDCDCDCDCDCD")]
        public string PrfSeedBytes {
            get {
                return ((string)(this["PrfSeedBytes"]));
            }
            set {
                this["PrfSeedBytes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("104")]
        public decimal PrfBytesToGenerate {
            get {
                return ((decimal)(this["PrfBytesToGenerate"]));
            }
            set {
                this["PrfBytesToGenerate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Jefe")]
        public string HmacKey {
            get {
                return ((string)(this["HmacKey"]));
            }
            set {
                this["HmacKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("what do ya want for nothing?")]
        public string HmacData {
            get {
                return ((string)(this["HmacData"]));
            }
            set {
                this["HmacData"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"4456: SSL[131491792]: Pre-Master Secret [Len: 48]
   03 01 bb 7b 08 98 a7 49 de e8 e9 b8 91 52 ec 81   ...{...I.....R..
   4c c2 39 7b f6 ba 1c 0a b1 95 50 29 be 02 ad e6   L.9{......P)....
   ad 6e 11 3f 20 c4 66 f0 64 22 57 7e e1 06 7a 3b   .n.? .f.d""W~..z;
")]
        public string PreMasterSecret {
            get {
                return ((string)(this["PreMasterSecret"]));
            }
            set {
                this["PreMasterSecret"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4a2f07cab94fb3067a06567fcec9f737bd5270f7002bb0d6723e551a0d57d982")]
        public string ClientRandomBytes {
            get {
                return ((string)(this["ClientRandomBytes"]));
            }
            set {
                this["ClientRandomBytes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4a2f07ca986be7a3acdd547d038235895aba467eed6eb07cd46e5e8a199e0c13")]
        public string ServerRandomBytes {
            get {
                return ((string)(this["ServerRandomBytes"]));
            }
            set {
                this["ServerRandomBytes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"0100009a03014a2f07cab94fb3067a06567fcec9f737bd5270f7002bb0d6723e551a0d57d982000044c00ac0140088008700390038c00fc00500840035c007c009c011c0130045004400330032c00cc00ec002c004004100040005002fc008c01200160013c00dc003feff000a0100002d00000013001100000e7777772e616d617a6f6e2e636f6d000a00080006001700180019000b0002010000230000")]
        public string ClientHello {
            get {
                return ((string)(this["ClientHello"]));
            }
            set {
                this["ClientHello"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0200004603014a2f07ca986be7a3acdd547d038235895aba467eed6eb07cd46e5e8a199e0c1320acd" +
            "07167996609e3584d15c2d43596d8ab93cfa9e899a82aa1652b8ab667a12b000400")]
        public string ServerHello {
            get {
                return ((string)(this["ServerHello"]));
            }
            set {
                this["ServerHello"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0b0009a000099d0004f7308204f3308203dba0030201020210169d041c3130be3d566606f2679ba17" +
            "2300d06092a864886f70d01010505003081b0310b300906035504061302555331173015060355040" +
            "a130e566572695369676e2c20496e632e311f301d060355040b1316566572695369676e205472757" +
            "374204e6574776f726b313b3039060355040b13325465726d73206f6620757365206174206874747" +
            "0733a2f2f7777772e766572697369676e2e636f6d2f727061202863293035312a302806035504031" +
            "321566572695369676e20436c61737320332053656375726520536572766572204341301e170d303" +
            "8303832373030303030305a170d3039303832373233353935395a3067310b3009060355040613025" +
            "553311330110603550408130a57617368696e67746f6e3110300e0603550407140753656174746c6" +
            "531183016060355040a140f416d617a6f6e2e636f6d20496e632e311730150603550403140e77777" +
            "72e616d617a6f6e2e636f6d30819f300d06092a864886f70d010101050003818d003081890281810" +
            "0c5176d5880046305c91466c7b7f2ed05d6f3f528212f0e829c86dbf35981cd6f5c669aff9e2d937" +
            "38e795a347501aa7bb90379fc085405827744914d160f2f3ade9a793413eba875e323e5a82ba577b" +
            "45d0908be25ccd5fd44916971f9a772533d7edffcf7cc84241cc803cd8e5764ea121169c988670e1" +
            "c28550351a58b2adb0203010001a38201d3308201cf30090603551d1304023000300b0603551d0f0" +
            "404030205a030440603551d1f043d303b3039a037a0358633687474703a2f2f53565253656375726" +
            "52d63726c2e766572697369676e2e636f6d2f535652536563757265323030352e63726c304406035" +
            "51d20043d303b3039060b6086480186f84501071703302a302806082b06010505070201161c68747" +
            "470733a2f2f7777772e766572697369676e2e636f6d2f727061301d0603551d250416301406082b0" +
            "601050507030106082b06010505070302301f0603551d230418301680146fecafa0dd8aa4eff52a1" +
            "0672d3f5582bcd7ef25307906082b06010505070101046d306b302406082b0601050507300186186" +
            "87474703a2f2f6f6373702e766572697369676e2e636f6d304306082b06010505073002863768747" +
            "4703a2f2f5356525365637572652d6169612e766572697369676e2e636f6d2f53565253656375726" +
            "5323030352d6169612e636572306e06082b0601050507010c04623060a15ea05c305a30583056160" +
            "9696d6167652f6769663021301f300706052b0e03021a04144b6bb92896060cbbd052389b29ac4b0" +
            "78b21051830261624687474703a2f2f6c6f676f2e766572697369676e2e636f6d2f76736c6f676f3" +
            "12e676966300d06092a864886f70d010105050003820101003feb3eff141d141d684f6d0c571d2c0" +
            "5e0df6161174a949272d043c6d5f20172193abba420fda6f193312c6d8b91ad6a41c993b2f99cf68" +
            "0d3767049d067447c4b43864f91e2c3c2f6f0703f7d3044e77ec83058ce81634773cdcb019301e91" +
            "89cba318316a793b5f9f5230ff832d2d661f7c05587666cd757052ce5967ec836743aa68b526903d" +
            "09db325bb8547892d5c924ae3ff3fa9a854d4d84a9b7af7a8cd8237db964c843a876b8385d955d64" +
            "fcb2aacf40b15e8a06e0491c3bc6892a420d828af09738ff492fc23b9c521d7cff6175fba59cbd0c" +
            "dd5b9f99876fad5fa98904a2338330336d66906cd196f8b8b173070aef1d14f8c18c38fefc328667" +
            "30004a03082049c30820405a003020102021075337d9ab0e1233bae2d7de4469162d4300d06092a8" +
            "64886f70d0101050500305f310b300906035504061302555331173015060355040a130e566572695" +
            "369676e2c20496e632e31373035060355040b132e436c6173732033205075626c6963205072696d6" +
            "172792043657274696669636174696f6e20417574686f72697479301e170d3035303131393030303" +
            "030305a170d3135303131383233353935395a3081b0310b300906035504061302555331173015060" +
            "355040a130e566572695369676e2c20496e632e311f301d060355040b1316566572695369676e205" +
            "472757374204e6574776f726b313b3039060355040b13325465726d73206f6620757365206174206" +
            "8747470733a2f2f7777772e766572697369676e2e636f6d2f727061202863293035312a302806035" +
            "504031321566572695369676e20436c6173732033205365637572652053657276657220434130820" +
            "122300d06092a864886f70d01010105000382010f003082010a028201010095c321128e40c50d015" +
            "f765e6694d9732c581922b8c9fc7a39902a77727c1d3ef7d855e3af42cb873002dc5bac70e6b844b" +
            "42b35eb93d217057ecb46d65c53a032519d746458f90c9a00ea5e44496472f4cd10e2850af934eeb" +
            "38866a9a5a45ad00e987f580d2b52bb86a97e2efab2487c8ddb2d5f0175a28d063b8bb46107c9be2" +
            "299f81bd1b55766044d35f4917196b59908259b97c83af320b1dd9e980c4a63b7a6ceb001cef8936" +
            "af30c6e9fb1e9847b819841e681dc3d2ce7b46be39efc0816d7b3d5b96612997c6d71c84dbec70fe" +
            "3fb37add57587216b86d044145a547939966956c9b931cd896158e1d9760505adf7b902afa7fd479" +
            "1a222345a31d10203010001a38201813082017d30120603551d130101ff040830060101ff0201003" +
            "0440603551d20043d303b3039060b6086480186f84501071703302a302806082b060105050702011" +
            "61c68747470733a2f2f7777772e766572697369676e2e636f6d2f72706130310603551d1f042a302" +
            "83026a024a0228620687474703a2f2f63726c2e766572697369676e2e636f6d2f706361332e63726" +
            "c300e0603551d0f0101ff040403020106301106096086480186f8420101040403020106302906035" +
            "51d1104223020a41e301c311a301806035504031311436c617373334341323034382d312d3435301" +
            "d0603551d0e041604146fecafa0dd8aa4eff52a10672d3f5582bcd7ef253081800603551d2304793" +
            "077a163a461305f310b300906035504061302555331173015060355040a130e566572695369676e2" +
            "c20496e632e31373035060355040b132e436c6173732033205075626c6963205072696d617279204" +
            "3657274696669636174696f6e20417574686f72697479821070bae41d10d92934b638ca7b03ccbab" +
            "f300d06092a864886f70d010105050003818100c37e08465d9136cf67dcd7a7afafb822c38b0474d" +
            "3b160bce6feb74412815b3173146356c6722ed11a03435c380a504a4dcddab619a8f4990dafe3f7d" +
            "8f1752865f66afe9bf4bd52d93fcbda16cba59e2e8e6652783d26fafe9436884a955e2a4c19ef6ef" +
            "a823f2d03efd628b33718cf42b234216447d3206b3a4cdce603900c")]
        public string ServerHelloCertificate {
            get {
                return ((string)(this["ServerHelloCertificate"]));
            }
            set {
                this["ServerHelloCertificate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0e000000")]
        public string ServerHelloDone {
            get {
                return ((string)(this["ServerHelloDone"]));
            }
            set {
                this["ServerHelloDone"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"1000008200808c0863cc016cd036efa22889e1611a8a03304366ebb04da1cb918548e024f488a155cd85030b5bd7e67a9da2019089ceba571100051cafceeff42b3fe630f26e7d55e6d6c80976851da2517e28bf831ebe0bed601c9b00c52ea62238eda3fb7edd689ac2addc2341ba30f0cd95604885ed448e828346c3b71206ae48114eb2da")]
        public string ClientEncryptedKeyExchange {
            get {
                return ((string)(this["ClientEncryptedKeyExchange"]));
            }
            set {
                this["ClientEncryptedKeyExchange"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("6a207a41660bd66cf7be3f41ded028c24a612db5301673c1e6317a42222c2f96")]
        public string ClientEncryptedFinishedMessage {
            get {
                return ((string)(this["ClientEncryptedFinishedMessage"]));
            }
            set {
                this["ClientEncryptedFinishedMessage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4c95745d193fd3d4645d95280a49b80e02d4d479b44475cae3527b9e808ecc69")]
        public string ServerEncryptedFinishedMessage {
            get {
                return ((string)(this["ServerEncryptedFinishedMessage"]));
            }
            set {
                this["ServerEncryptedFinishedMessage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"183AF27ABF7AE61392D03958A7D4CC9D7B37CF30A52DFD2DD9546538FE2E9DB30A49AF7AB7265E56F12E07D12359DDE4456F222E8F135187A095817D4CDE3C66A54AEE91F9F347D076E81C1C6D533CB11BD3193EBDC5E5F711DC42B099559E287A7FA0867AEB830B6CC076A7E6665BBD341BA0E31CBCF3D9A067AD7B4038A1F3BDB3BCE7790E27E2FFF67E5D3518405E37D6A66A76F6E1DBA32DB9A69BDCDE33002627051E1BDBFBF64F6D3FB33EE301139ADA7D03F5F00AC193D3EB05D83198D2EB722848E8ABBC97FE529863E54A098621E6DE5F00DA7BC70DB6FDCD11F9DDE3C33AB15DFBFADD8F8D90E564B2D4DB1E25F5FE28E4D748AD01E42CEE5B30745404C4324C1CC4A421F85C65019B87A9C5CFCCB34D90D45195E28E6E30686D77B4F2F727DB2F583F7137BC0F1D22D59DF897C2B14C77B4C50BA97F88C7CB38B3478FE825970250851A95C9D546D6BB39B265CBBF944F35D0F0924D8D9F4BC05A7D7C55165F81D81B52F0B0BF92D6FDB67C35079B286E0886ACC380C047A031FC6FB5B46DA45D81EBC440CD34229282FDE09FCFCA8E28C0C11DFF664CB486C11BA64A70E73192A66951E206492713173CDDC988515D973E1531155C548E6D8FF5AD623F6C009D2916F1B45E9A0FE80EED21B29A200975EAFAFC982104482A8BEB4DCA45B605E3B2F9984B6E51FEFE86C5B82FC0C9CBA092070450A14D")]
        public string ClientApplicationData {
            get {
                return ((string)(this["ClientApplicationData"]));
            }
            set {
                this["ClientApplicationData"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"7FEF3541D25C5F37F46461988729B6EF873D59F35C844B1BFA23D1F257C670FB2E26E6FD5F5162849401E966D1E65EE39FAFB65D1B882F6E3284B1B473B00749F00AA656C8496C9FB09FD62E6D5A09ABA51BB474A63B521A28702A74B24E658065DAA1793D971FD5DD7B433BC9EBBFA1E3B92A4FF35A496740EA9691C1F4A57CAA28213DB2CAEF38E4D94CFEE4102FF34EC669280F0303A24025581E281F4F421917F169329F730B5C62CF68EF3CCEBCDCCE3E9DF78652F1A43E4986B9DE9CC2F7DA5563A34CF417EFD045EF46DAAD8CA3D72E50E4F3B0D4323399AE647DF8A7B9A12E103E0C79A222F798BC9C2317D85929C6E73C96EE03CC63B0FF2F4C94E411B9A6F536AFD7BDBAD279171CD6C39B2018161889A18998BCB92B4D250CD6249F6763BCAF1E03ED12DA38D5D71C79CAAFDB0BA823E702645852D923577F35CC82F59A5AF91B13901042F9AB4CAAD09CFD6226FA4AA92F14D96698E639245BF2F247927EE92466395A16EF31949EBD75428E57D43848E15C66F44E207A69AD301F9CE5826ABFEBCA4927D1BED3331CEEFB9E8C959C97245CB65EDF7EA24F31FC59BC312DA9A3AE81E3C34418ED69FAC2FFAC61D90BE93521633CD10266334F6AE59A69B6B733CE1A6E01D119B91FCAC2571062C0EB2FC79601405D1F349213AED9E9D520DAD50F9FE6E39CE9B96607D6934CBF1C0870F1761A7421BCBCED09D3896012B92281D1E1CB92
4939489ACA4CB1FFE5D096AA9F944746")]
        public string ServerApplicationData {
            get {
                return ((string)(this["ServerApplicationData"]));
            }
            set {
                this["ServerApplicationData"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"00 02 12 A3 EA B1 65 D6 81 6C 13 14 13 62 10 53 23 B3 96 85 FF 24 FA CC 46 11 21 24 A4 81 EA 30 63 95 D4 DC BF 9C CC D0 2E DD 5A A6 41 6A 4E 82 65 7D 70 7D 50 09 17 CD 10 55 97 B9 C1 A1 84 F2 A9 AB EA 7D F4 CC 54 E4 64 6E 3A E5 91 A0 06 00 03 01 BB 7B 08 98 A7 49 DE E8 E9 B8 91 52 EC 81 4C C2 39 7B F6 BA 1C 0A B1 95 50 29 BE 02 AD E6 AD 6E 11 3F 20 C4 66 F0 64 22 57 7E E1 06 7A 3B")]
        public string DecryptedClientKeyExchange {
            get {
                return ((string)(this["DecryptedClientKeyExchange"]));
            }
            set {
                this["DecryptedClientKeyExchange"] = value;
            }
        }
    }
}