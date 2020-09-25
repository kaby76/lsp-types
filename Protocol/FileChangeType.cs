namespace LspTypes
{
    /**
     * The file event type.
     */
    public enum FileChangeType
    {
        /**
         * The file got created.
         */
        Created = 1,
            
        /**
         * The file got changed.
         */
        Changed = 2,

        /**
         * The file got deleted.
         */
        Deleted = 3,
    }
}
