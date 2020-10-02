/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.IdentityService.Models;
using Oci.IdentityService.Requests;
using Oci.IdentityService.Responses;

namespace Oci.IdentityService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of Identity.
    /// </summary>
    public class IdentityWaiters
    {
        private readonly IdentityClient client;

        public  IdentityWaiters(IdentityClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetCompartmentRequest, GetCompartmentResponse> ForCompartment(GetCompartmentRequest request, params Compartment.LifecycleStateEnum[] targetStates)
        {
            return this.ForCompartment(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetCompartmentRequest, GetCompartmentResponse> ForCompartment(GetCompartmentRequest request, WaiterConfiguration config, params Compartment.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetCompartmentRequest, GetCompartmentResponse>(
                request,
                request => client.GetCompartment(request),
                response => targetStates.Contains(response.Compartment.LifecycleState.Value),
                targetStates.Contains(Compartment.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetCompartmentRequest, GetCompartmentResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDynamicGroupRequest, GetDynamicGroupResponse> ForDynamicGroup(GetDynamicGroupRequest request, params DynamicGroup.LifecycleStateEnum[] targetStates)
        {
            return this.ForDynamicGroup(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDynamicGroupRequest, GetDynamicGroupResponse> ForDynamicGroup(GetDynamicGroupRequest request, WaiterConfiguration config, params DynamicGroup.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetDynamicGroupRequest, GetDynamicGroupResponse>(
                request,
                request => client.GetDynamicGroup(request),
                response => targetStates.Contains(response.DynamicGroup.LifecycleState.Value),
                targetStates.Contains(DynamicGroup.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetDynamicGroupRequest, GetDynamicGroupResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetGroupRequest, GetGroupResponse> ForGroup(GetGroupRequest request, params Group.LifecycleStateEnum[] targetStates)
        {
            return this.ForGroup(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetGroupRequest, GetGroupResponse> ForGroup(GetGroupRequest request, WaiterConfiguration config, params Group.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetGroupRequest, GetGroupResponse>(
                request,
                request => client.GetGroup(request),
                response => targetStates.Contains(response.Group.LifecycleState.Value),
                targetStates.Contains(Group.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetGroupRequest, GetGroupResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetIdentityProviderRequest, GetIdentityProviderResponse> ForIdentityProvider(GetIdentityProviderRequest request, params IdentityProvider.LifecycleStateEnum[] targetStates)
        {
            return this.ForIdentityProvider(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetIdentityProviderRequest, GetIdentityProviderResponse> ForIdentityProvider(GetIdentityProviderRequest request, WaiterConfiguration config, params IdentityProvider.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetIdentityProviderRequest, GetIdentityProviderResponse>(
                request,
                request => client.GetIdentityProvider(request),
                response => targetStates.Contains(response.IdentityProvider.LifecycleState.Value),
                targetStates.Contains(IdentityProvider.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetIdentityProviderRequest, GetIdentityProviderResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetIdpGroupMappingRequest, GetIdpGroupMappingResponse> ForIdpGroupMapping(GetIdpGroupMappingRequest request, params IdpGroupMapping.LifecycleStateEnum[] targetStates)
        {
            return this.ForIdpGroupMapping(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetIdpGroupMappingRequest, GetIdpGroupMappingResponse> ForIdpGroupMapping(GetIdpGroupMappingRequest request, WaiterConfiguration config, params IdpGroupMapping.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetIdpGroupMappingRequest, GetIdpGroupMappingResponse>(
                request,
                request => client.GetIdpGroupMapping(request),
                response => targetStates.Contains(response.IdpGroupMapping.LifecycleState.Value),
                targetStates.Contains(IdpGroupMapping.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetIdpGroupMappingRequest, GetIdpGroupMappingResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetPolicyRequest, GetPolicyResponse> ForPolicy(GetPolicyRequest request, params Policy.LifecycleStateEnum[] targetStates)
        {
            return this.ForPolicy(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetPolicyRequest, GetPolicyResponse> ForPolicy(GetPolicyRequest request, WaiterConfiguration config, params Policy.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetPolicyRequest, GetPolicyResponse>(
                request,
                request => client.GetPolicy(request),
                response => targetStates.Contains(response.Policy.LifecycleState.Value),
                targetStates.Contains(Policy.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetPolicyRequest, GetPolicyResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetTagRequest, GetTagResponse> ForTag(GetTagRequest request, params Tag.LifecycleStateEnum[] targetStates)
        {
            return this.ForTag(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetTagRequest, GetTagResponse> ForTag(GetTagRequest request, WaiterConfiguration config, params Tag.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetTagRequest, GetTagResponse>(
                request,
                request => client.GetTag(request),
                response => targetStates.Contains(response.Tag.LifecycleState.Value),
                targetStates.Contains(Tag.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetTagRequest, GetTagResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetTagDefaultRequest, GetTagDefaultResponse> ForTagDefault(GetTagDefaultRequest request, params TagDefault.LifecycleStateEnum[] targetStates)
        {
            return this.ForTagDefault(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetTagDefaultRequest, GetTagDefaultResponse> ForTagDefault(GetTagDefaultRequest request, WaiterConfiguration config, params TagDefault.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetTagDefaultRequest, GetTagDefaultResponse>(
                request,
                request => client.GetTagDefault(request),
                response => targetStates.Contains(response.TagDefault.LifecycleState.Value)
            );
            return new Waiter<GetTagDefaultRequest, GetTagDefaultResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetTagNamespaceRequest, GetTagNamespaceResponse> ForTagNamespace(GetTagNamespaceRequest request, params TagNamespace.LifecycleStateEnum[] targetStates)
        {
            return this.ForTagNamespace(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetTagNamespaceRequest, GetTagNamespaceResponse> ForTagNamespace(GetTagNamespaceRequest request, WaiterConfiguration config, params TagNamespace.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetTagNamespaceRequest, GetTagNamespaceResponse>(
                request,
                request => client.GetTagNamespace(request),
                response => targetStates.Contains(response.TagNamespace.LifecycleState.Value),
                targetStates.Contains(TagNamespace.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetTagNamespaceRequest, GetTagNamespaceResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetTaggingWorkRequestRequest, GetTaggingWorkRequestResponse> ForTaggingWorkRequest(GetTaggingWorkRequestRequest request, params TaggingWorkRequest.StatusEnum[] targetStates)
        {
            return this.ForTaggingWorkRequest(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetTaggingWorkRequestRequest, GetTaggingWorkRequestResponse> ForTaggingWorkRequest(GetTaggingWorkRequestRequest request, WaiterConfiguration config, params TaggingWorkRequest.StatusEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetTaggingWorkRequestRequest, GetTaggingWorkRequestResponse>(
                request,
                request => client.GetTaggingWorkRequest(request),
                response => targetStates.Contains(response.TaggingWorkRequest.Status.Value)
            );
            return new Waiter<GetTaggingWorkRequestRequest, GetTaggingWorkRequestResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetUserRequest, GetUserResponse> ForUser(GetUserRequest request, params User.LifecycleStateEnum[] targetStates)
        {
            return this.ForUser(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetUserRequest, GetUserResponse> ForUser(GetUserRequest request, WaiterConfiguration config, params User.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetUserRequest, GetUserResponse>(
                request,
                request => client.GetUser(request),
                response => targetStates.Contains(response.User.LifecycleState.Value),
                targetStates.Contains(User.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetUserRequest, GetUserResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetUserGroupMembershipRequest, GetUserGroupMembershipResponse> ForUserGroupMembership(GetUserGroupMembershipRequest request, params UserGroupMembership.LifecycleStateEnum[] targetStates)
        {
            return this.ForUserGroupMembership(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetUserGroupMembershipRequest, GetUserGroupMembershipResponse> ForUserGroupMembership(GetUserGroupMembershipRequest request, WaiterConfiguration config, params UserGroupMembership.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetUserGroupMembershipRequest, GetUserGroupMembershipResponse>(
                request,
                request => client.GetUserGroupMembership(request),
                response => targetStates.Contains(response.UserGroupMembership.LifecycleState.Value),
                targetStates.Contains(UserGroupMembership.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetUserGroupMembershipRequest, GetUserGroupMembershipResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetWorkRequestRequest, GetWorkRequestResponse> ForWorkRequest(GetWorkRequestRequest request, params WorkRequest.StatusEnum[] targetStates)
        {
            return this.ForWorkRequest(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetWorkRequestRequest, GetWorkRequestResponse> ForWorkRequest(GetWorkRequestRequest request, WaiterConfiguration config, params WorkRequest.StatusEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetWorkRequestRequest, GetWorkRequestResponse>(
                request,
                request => client.GetWorkRequest(request),
                response => targetStates.Contains(response.WorkRequest.Status.Value)
            );
            return new Waiter<GetWorkRequestRequest, GetWorkRequestResponse>(config, agent);
        }
    }
}
