﻿using System.Collections.Generic;
using Tortuga.Chain;

namespace RawBencher.Benchers
{
    /// <summary>
    /// Specific bencher for Tortuga Chain using a Table/Row result, doing no-change tracking fetch
    /// </summary>
    public class ChainDynamicBencher : FetchOnlyBencherBase<dynamic>
    {
        SqlServerDataSource DataSource;
        string m_ConnectionStringToUse;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChainBencher"/> class.
        /// </summary>
        public ChainDynamicBencher()
            : base(e => e.SalesOrderID, usesChangeTracking: false, usesCaching: false)
        {
        }

        /// <summary>
        /// Fetches the individual element
        /// </summary>
        /// <param name="key">The key of the element to fetch.</param>
        /// <returns>The fetched element, or null if not found</returns>
        public override dynamic FetchIndividual(int key)
        {
            return DataSource.From("[Sales].[SalesOrderHeader]", new { SalesOrderId = key }).ToDynamicObject().Execute();
        }

        /// <summary>
        /// Fetches the complete set of elements and returns this set as an IEnumerable.
        /// </summary>
        /// <returns>the set fetched</returns>
        public override IEnumerable<dynamic> FetchSet()
        {
            return DataSource.From("[Sales].[SalesOrderHeader]").ToDynamicCollection().Execute();
        }

        /// <summary>
        /// Creates the name of the framework this bencher is for. Use the overload which accepts a format string and a type to create a name based on a
        /// specific version
        /// </summary>
        /// <returns>the framework name.</returns>
        protected override string CreateFrameworkNameImpl()
        {
            return "Tortuga Chain, dynamic objects v" + BencherUtils.GetVersion(typeof(SqlServerDataSource));
        }

        #region Properties

        /// <summary>
        /// Gets or sets the command text.
        /// </summary>
        public string CommandText { get; set; }

        /// <summary>
        /// Gets or sets the connection string to use
        /// </summary>
        public string ConnectionStringToUse
        {
            get
            {
                return m_ConnectionStringToUse;
            }
            set
            {
                if (m_ConnectionStringToUse == value)
                    return;
                if (value == null)
                    return;

                m_ConnectionStringToUse = value;
                DataSource = new SqlServerDataSource(value);
            }
        }

        #endregion Properties
    }
}