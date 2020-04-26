using System;
using System.Collections.Generic;
using System.Text;

namespace week11StrategyPattern
{
    class EncryptLogger : EncryptionStrategy
    {
       
        private FileLogger logger;
        private EncryptionStrategy currEncryptionStrategy;


        public EncryptLogger(FileLogger logger)
        {
            this.logger = logger;
            SimpleEncryption ee = new SimpleEncryption();
            this.currEncryptionStrategy = ee;
        }

        internal void setEncryptionStrategy(EncryptionStrategy strategy)
        {
            this.currEncryptionStrategy = strategy;
        }

        internal void log(string v1, string v2)
        {
            String encryptedMsg = encrypt(v2);
            logger.log(v1, encryptedMsg);
        }

  

        public string encrypt(string v)
        {
           return this.currEncryptionStrategy.encrypt(v);
        }
    }
}
