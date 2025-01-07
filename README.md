# NeoMnemonic

Neo 3 中的助记词生成算法（按照比特币 BIP32 BIP39 BIP41 标准实现）。

注：Neo3 助记词的衍生路径为 m/44'/888'/0'/0/0 因为币种不同（比特币币种为 0，Neo 币种为 888），同样的助记词，导入比特币钱包和导入 Neo 钱包会得到不同的私钥，这是正常现象。

兼容钱包：

- OneGate、https://iancoleman.io/bip39/ （在网址中手动指定派生路径 m/44'/888'/0'/0/0）
- neon、Ledger

## 示例

生成助记词

[BIP39 Wordlists](https://github.com/bitcoin/bips/blob/master/bip-0039/bip-0039-wordlists.md)

```csharp
Mnemonic.GenerateMnemonic();

Mnemonic.GenerateMnemonic(EntropyLength._128)

Mnemonic.GenerateMnemonic(EntropyLength._128, Mnemonic.Language.ChineseSimplified)
```

通过助记词和口令（可选）生成种子

```csharp
Mnemonic.MnemonicToSeed(words);

Mnemonic.MnemonicToSeed(words, "passphrase");
```

> 错误情况：
>
> 1、助记词单词数必须为 12 或 15 或 18 或 21 或 24
>
> 2、助记词必须为助记词列表中的单词
>
> 3、助记词校验不通过

通过种子生成 neo 的私钥

```
Mnemonic.SeedToWIF_1(seed); //兼容onegate
Mnemonic.SeedToWIF_2(seed); //兼容neon, neoline
```

## 兼容性问题

为什么 OneGate 和 neon 的相同的助记词导入后地址不同？

OneGate 引用的是 bip32/bip39 库

- 按照 bip32 规范，masterkey 的 fingerprint 应该是 4 字节的 [0,0,0,0]
- HMACSHA512算法的密钥为默认的 Bitcoin seed
- 派生路径时用的曲线是 Secp256k1

neon 使用了 Moonlight-io/asteroid-sdk-js 库

- masterkey 的 fingerprint 是一个字节的 [46]，就是 '0' 的 ASCII 码
- HMACSHA512 算法的密钥为了 Nist256p1 seed
- 派生路径时用的曲线是 Secp256r1

另外二者对BitInteger的实现略有不同，导致了最终同样 seed 生成的私钥不同。

## 参考：

[BIP39](https://github.com/bitcoin/bips/blob/master/bip-0039.mediawiki)

[BIP32](https://github.com/bitcoin/bips/blob/master/bip-0032.mediawiki)

[BIP43](https://github.com/bitcoin/bips/blob/master/bip-0043.mediawiki)

[BIP44](https://github.com/bitcoin/bips/blob/master/bip-0044.mediawiki)

[比特币源码学习-钱包标准(一)-BIP32/BIP44](https://blog.csdn.net/m0_37847176/article/details/82011876)

[比特币源码学习-钱包标准（二）-BIP39](https://blog.csdn.net/m0_37847176/article/details/82177627)

[助记词 - 廖雪峰的官方网站](https://www.liaoxuefeng.com/wiki/1207298049439968/1207320517404448)

[理解开发HD 钱包涉及的 BIP32、BIP44、BIP39](https://learnblockchain.cn/2018/09/28/hdwallet/)

[基于 BIP-32 和 BIP-39 规范生成 HD 钱包（分层确定性钱包）](https://stevenocean.github.io/2018/09/23/generate-hd-wallet-by-bip39.html)
